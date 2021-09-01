## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       r9,[rsi+28]
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B7538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1F2F5F83020
       mov       r9,[r9]
       mov       r8,1F2F5F91850
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B77C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B7870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
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
; Total bytes of code 240
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       r9,[rsi+28]
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF7AD3D7988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1CEB0853020
       mov       r9,[r9]
       mov       r8,1CEA08521F8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF7AD3D7C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF7AD3D7CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
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
; Total bytes of code 240
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       r9,[rsi+28]
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A79A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,28B832F3020
       mov       r9,[r9]
       mov       r8,28BA32F31D8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A7C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A7CD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
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
; Total bytes of code 240
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       r9,[rsi+28]
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B7960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,22D85453020
       mov       r9,[r9]
       mov       r8,22D954511E0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B7BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B7C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
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
; Total bytes of code 240
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       r9,[rsi+28]
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B79A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,22B70981028
       mov       r9,[r9]
       mov       r8,22B509841F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B7C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF7AD3B7CD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
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
; Total bytes of code 240
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       r9,[rsi+28]
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A7988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1A50F843020
       mov       r9,[r9]
       mov       r8,1A51F8411E0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A7C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A7CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
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
; Total bytes of code 240
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       r9,[rsi+28]
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsi+10]
       mov       r11,[r14+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A7960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,26C44AD3020
       mov       r9,[r9]
       mov       r8,26C44AE2068
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A7BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L06
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FF7AD3A7C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
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
; Total bytes of code 240
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,[rsi+120]
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
       test      rsi,rsi
       je        short M01_L00
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1ACEB3B3020
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
       cmp       [rcx],ecx
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
       mov       r8,1ACEB3B1348
       mov       r8,[r8]
       mov       rdx,1ACCB3B19F8
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
       mov       rdx,7FF7AD3B7B40
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
       mov       rdx,7FF7AD3B7C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       add       r8d,[rdi+18]
       sub       r8d,1
       jo        short M01_L07
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
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       je        short M01_L08
       mov       rax,[rsi+28]
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF7AD3B7C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L09:
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
; Total bytes of code 504
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,[rsi+120]
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
       test      rsi,rsi
       je        short M01_L00
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1B354AB3020
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
       cmp       [rcx],ecx
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
       mov       r8,1B354AB1348
       mov       r8,[r8]
       mov       rdx,1B374AB21F8
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
       mov       rdx,7FF7AD3B7B40
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
       mov       rdx,7FF7AD3B7C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       add       r8d,[rdi+18]
       sub       r8d,1
       jo        short M01_L07
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
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       je        short M01_L08
       mov       rax,[rsi+28]
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF7AD3B7C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L09:
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
; Total bytes of code 504
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,[rsi+120]
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
       test      rsi,rsi
       je        short M01_L00
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,2895B563020
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
       cmp       [rcx],ecx
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
       mov       r8,2895B561348
       mov       r8,[r8]
       mov       rdx,2895B5655E8
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
       mov       rdx,7FF7AD3D7FA8
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
       mov       rdx,7FF7AD3D8098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       add       r8d,[rdi+18]
       sub       r8d,1
       jo        short M01_L07
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
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       je        short M01_L08
       mov       rax,[rsi+28]
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF7AD3D8098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L09:
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
; Total bytes of code 504
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,[rsi+120]
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
       test      rsi,rsi
       je        short M01_L00
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,2D0B94C3020
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
       cmp       [rcx],ecx
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
       mov       r8,2D0B94C1348
       mov       r8,[r8]
       mov       rdx,2D0B94C55E8
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
       mov       rdx,7FF7AD3C7F68
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
       mov       rdx,7FF7AD3C8058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       add       r8d,[rdi+18]
       sub       r8d,1
       jo        short M01_L07
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
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       je        short M01_L08
       mov       rax,[rsi+28]
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF7AD3C8058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L09:
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
; Total bytes of code 504
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,[rsi+120]
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
       test      rsi,rsi
       je        short M01_L00
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1B75D7B3020
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
       cmp       [rcx],ecx
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
       mov       r8,1B75D7B1348
       mov       r8,[r8]
       mov       rdx,1B75D7C1850
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
       mov       rdx,7FF7AD3B7F68
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
       mov       rdx,7FF7AD3B8058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       add       r8d,[rdi+18]
       sub       r8d,1
       jo        short M01_L07
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
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       je        short M01_L08
       mov       rax,[rsi+28]
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF7AD3B8058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L09:
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
; Total bytes of code 504
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,[rsi+120]
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
       test      rsi,rsi
       je        short M01_L00
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,244EA763020
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
       cmp       [rcx],ecx
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
       mov       r8,244EA761348
       mov       r8,[r8]
       mov       rdx,244EA7655E8
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
       mov       rdx,7FF7AD3C7F68
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
       mov       rdx,7FF7AD3C8058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       add       r8d,[rdi+18]
       sub       r8d,1
       jo        short M01_L07
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
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       je        short M01_L08
       mov       rax,[rsi+28]
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF7AD3C8058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L09:
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
; Total bytes of code 504
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,[rsi+120]
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
       test      rsi,rsi
       je        short M01_L00
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1ED86EE1028
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
       cmp       [rcx],ecx
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
       mov       r8,1ED66EE1348
       mov       r8,[r8]
       mov       rdx,1ED86EE35F0
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
       mov       rdx,7FF7AD3D7F68
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
       mov       rdx,7FF7AD3D8058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB0]
       call      rax
       mov       r8d,[rdi+1C]
       add       r8d,[rdi+18]
       sub       r8d,1
       jo        short M01_L07
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
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       je        short M01_L08
       mov       rax,[rsi+28]
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF7AD3D8058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L09:
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
; Total bytes of code 504
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+120]
       mov       rbx,[rsi+28]
       mov       rcx,rbx
       mov       rbp,[rcx+48]
       mov       rcx,rdi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD28CD18]
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M01_L03
M01_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF7AD3A9138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M01_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M01_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M01_L12
M01_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M01_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M01_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M01_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF7AD3A9128
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L10
M01_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M01_L08
       mov       r10,[rsp+20]
       jmp       short M01_L09
M01_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3A90F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M01_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M01_L10:
       test      eax,eax
       jne       short M01_L13
M01_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M01_L17
       test      r15d,r15d
       jge       near ptr M01_L04
M01_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       test      r13d,r13d
       jge       short M01_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M01_L15
M01_L14:
       cmp       r13d,[rsp+3C]
       jae       short M01_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M01_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M02_L22
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3A9138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M02_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M02_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3A9128
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M02_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M02_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M02_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M02_L09
M02_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],r8d
       jmp       short M02_L07
M02_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L23
M02_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M02_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M02_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L13
       mov       r10,[rsp+38]
       jmp       short M02_L14
M02_L13:
       mov       rdx,7FF7AD3A90F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M02_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L15:
       cmp       r13d,2
       je        near ptr M02_L26
       jmp       near ptr M02_L11
M02_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M02_L12
M02_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M02_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M02_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M02_L20
M02_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M02_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M02_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M02_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M02_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M02_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M02_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M02_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L25
M02_L24:
       mov       rdx,7FF7AD3A9108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FF7AD3A9108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+120]
       mov       rbx,[rsi+28]
       mov       rcx,rbx
       mov       rbp,[rcx+48]
       mov       rcx,rdi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD28CD18]
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M01_L03
M01_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF7AD3A9588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M01_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M01_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M01_L12
M01_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M01_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M01_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M01_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF7AD3A9578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L10
M01_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M01_L08
       mov       r10,[rsp+20]
       jmp       short M01_L09
M01_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3A9540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M01_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M01_L10:
       test      eax,eax
       jne       short M01_L13
M01_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M01_L17
       test      r15d,r15d
       jge       near ptr M01_L04
M01_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       test      r13d,r13d
       jge       short M01_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M01_L15
M01_L14:
       cmp       r13d,[rsp+3C]
       jae       short M01_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M01_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M02_L22
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3A9588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M02_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M02_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3A9578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M02_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M02_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M02_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M02_L09
M02_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],r8d
       jmp       short M02_L07
M02_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L23
M02_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M02_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M02_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L13
       mov       r10,[rsp+38]
       jmp       short M02_L14
M02_L13:
       mov       rdx,7FF7AD3A9540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M02_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L15:
       cmp       r13d,2
       je        near ptr M02_L26
       jmp       near ptr M02_L11
M02_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M02_L12
M02_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M02_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M02_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M02_L20
M02_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M02_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M02_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M02_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M02_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M02_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M02_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M02_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L25
M02_L24:
       mov       rdx,7FF7AD3A9558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FF7AD3A9558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+120]
       mov       rbx,[rsi+28]
       mov       rcx,rbx
       mov       rbp,[rcx+48]
       mov       rcx,rdi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD29CD18]
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M01_L03
M01_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF7AD3B9560
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M01_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M01_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M01_L12
M01_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M01_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M01_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M01_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF7AD3B9550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L10
M01_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M01_L08
       mov       r10,[rsp+20]
       jmp       short M01_L09
M01_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3B9518
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M01_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M01_L10:
       test      eax,eax
       jne       short M01_L13
M01_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M01_L17
       test      r15d,r15d
       jge       near ptr M01_L04
M01_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       test      r13d,r13d
       jge       short M01_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M01_L15
M01_L14:
       cmp       r13d,[rsp+3C]
       jae       short M01_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M01_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M02_L22
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3B9560
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M02_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M02_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3B9550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M02_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M02_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M02_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M02_L09
M02_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],r8d
       jmp       short M02_L07
M02_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L23
M02_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M02_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M02_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L13
       mov       r10,[rsp+38]
       jmp       short M02_L14
M02_L13:
       mov       rdx,7FF7AD3B9518
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M02_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L15:
       cmp       r13d,2
       je        near ptr M02_L26
       jmp       near ptr M02_L11
M02_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M02_L12
M02_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M02_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M02_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M02_L20
M02_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M02_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M02_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M02_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M02_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M02_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M02_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M02_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L25
M02_L24:
       mov       rdx,7FF7AD3B9530
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FF7AD3B9530
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+120]
       mov       rbx,[rsi+28]
       mov       rcx,rbx
       mov       rbp,[rcx+48]
       mov       rcx,rdi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD28CD18]
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M01_L03
M01_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF7AD3A9588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M01_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M01_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M01_L12
M01_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M01_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M01_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M01_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF7AD3A9578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L10
M01_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M01_L08
       mov       r10,[rsp+20]
       jmp       short M01_L09
M01_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3A9540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M01_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M01_L10:
       test      eax,eax
       jne       short M01_L13
M01_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M01_L17
       test      r15d,r15d
       jge       near ptr M01_L04
M01_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       test      r13d,r13d
       jge       short M01_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M01_L15
M01_L14:
       cmp       r13d,[rsp+3C]
       jae       short M01_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M01_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M02_L22
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3A9588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M02_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M02_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3A9578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M02_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M02_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M02_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M02_L09
M02_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],r8d
       jmp       short M02_L07
M02_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L23
M02_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M02_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M02_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L13
       mov       r10,[rsp+38]
       jmp       short M02_L14
M02_L13:
       mov       rdx,7FF7AD3A9540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M02_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L15:
       cmp       r13d,2
       je        near ptr M02_L26
       jmp       near ptr M02_L11
M02_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M02_L12
M02_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M02_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M02_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M02_L20
M02_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M02_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M02_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M02_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M02_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M02_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M02_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M02_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L25
M02_L24:
       mov       rdx,7FF7AD3A9558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FF7AD3A9558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+120]
       mov       rbx,[rsi+28]
       mov       rcx,rbx
       mov       rbp,[rcx+48]
       mov       rcx,rdi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD29CD18]
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M01_L03
M01_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF7AD3B95B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M01_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M01_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M01_L12
M01_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M01_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M01_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M01_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF7AD3B95A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L10
M01_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M01_L08
       mov       r10,[rsp+20]
       jmp       short M01_L09
M01_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3B9570
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M01_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M01_L10:
       test      eax,eax
       jne       short M01_L13
M01_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M01_L17
       test      r15d,r15d
       jge       near ptr M01_L04
M01_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       test      r13d,r13d
       jge       short M01_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M01_L15
M01_L14:
       cmp       r13d,[rsp+3C]
       jae       short M01_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M01_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M02_L22
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3B95B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M02_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M02_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3B95A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M02_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M02_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M02_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M02_L09
M02_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],r8d
       jmp       short M02_L07
M02_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L23
M02_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M02_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M02_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L13
       mov       r10,[rsp+38]
       jmp       short M02_L14
M02_L13:
       mov       rdx,7FF7AD3B9570
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M02_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L15:
       cmp       r13d,2
       je        near ptr M02_L26
       jmp       near ptr M02_L11
M02_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M02_L12
M02_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M02_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M02_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M02_L20
M02_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M02_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M02_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M02_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M02_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M02_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M02_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M02_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L25
M02_L24:
       mov       rdx,7FF7AD3B9588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FF7AD3B9588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+120]
       mov       rbx,[rsi+28]
       mov       rcx,rbx
       mov       rbp,[rcx+48]
       mov       rcx,rdi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD29CD18]
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M01_L03
M01_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF7AD3B9588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M01_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M01_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M01_L12
M01_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M01_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M01_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M01_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF7AD3B9578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L10
M01_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M01_L08
       mov       r10,[rsp+20]
       jmp       short M01_L09
M01_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3B9540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M01_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M01_L10:
       test      eax,eax
       jne       short M01_L13
M01_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M01_L17
       test      r15d,r15d
       jge       near ptr M01_L04
M01_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       test      r13d,r13d
       jge       short M01_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M01_L15
M01_L14:
       cmp       r13d,[rsp+3C]
       jae       short M01_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M01_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M02_L22
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3B9588
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M02_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M02_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3B9578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M02_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M02_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M02_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M02_L09
M02_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],r8d
       jmp       short M02_L07
M02_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L23
M02_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M02_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M02_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L13
       mov       r10,[rsp+38]
       jmp       short M02_L14
M02_L13:
       mov       rdx,7FF7AD3B9540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M02_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L15:
       cmp       r13d,2
       je        near ptr M02_L26
       jmp       near ptr M02_L11
M02_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M02_L12
M02_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M02_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M02_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M02_L20
M02_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M02_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M02_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M02_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M02_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M02_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M02_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M02_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L25
M02_L24:
       mov       rdx,7FF7AD3B9558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FF7AD3B9558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.PersonProperDictionary;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+120]
       mov       rbx,[rsi+28]
       mov       rcx,rbx
       mov       rbp,[rcx+48]
       mov       rcx,rdi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD2BCD18]
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M01_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M01_L03
M01_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF7AD3D95A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M01_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M01_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M01_L12
M01_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M01_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M01_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M01_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF7AD3D9590
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L10
M01_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M01_L08
       mov       r10,[rsp+20]
       jmp       short M01_L09
M01_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3D9558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M01_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M01_L10:
       test      eax,eax
       jne       short M01_L13
M01_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M01_L17
       test      r15d,r15d
       jge       near ptr M01_L04
M01_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       test      r13d,r13d
       jge       short M01_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M01_L15
M01_L14:
       cmp       r13d,[rsp+3C]
       jae       short M01_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M01_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M02_L22
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3D95A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M02_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M02_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3D9590
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M02_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M02_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M02_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M02_L09
M02_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],r8d
       jmp       short M02_L07
M02_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L23
M02_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M02_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M02_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L13
       mov       r10,[rsp+38]
       jmp       short M02_L14
M02_L13:
       mov       rdx,7FF7AD3D9558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M02_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L21
M02_L15:
       cmp       r13d,2
       je        near ptr M02_L26
       jmp       near ptr M02_L11
M02_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M02_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M02_L12
M02_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M02_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M02_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M02_L20
M02_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M02_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M02_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M02_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M02_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M02_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M02_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M02_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M02_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L25
M02_L24:
       mov       rdx,7FF7AD3D9570
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M02_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FF7AD3D9570
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M02_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M02_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+120]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rbx,[rsp+28]
       mov       rbp,[rsp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD29CD18]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
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
       mov       rdx,7FF7AD3B75B8
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
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M02_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M02_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M02_L03
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3B9A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M02_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M02_L12
M02_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M02_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M02_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M02_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3B9A58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M02_L10
M02_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L08
       mov       r10,[rsp+20]
       jmp       short M02_L09
M02_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3B9A20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M02_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M02_L10:
       test      eax,eax
       jne       short M02_L13
M02_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M02_L17
       test      r15d,r15d
       jge       near ptr M02_L04
M02_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L13:
       test      r13d,r13d
       jge       short M02_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M02_L15
M02_L14:
       cmp       r13d,[rsp+3C]
       jae       short M02_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M02_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M03_L22
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M03_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rdx,7FF7AD3B9A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M03_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M03_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M03_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rdx,7FF7AD3B9A58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M03_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M03_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M03_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M03_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M03_L09
M03_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],r8d
       jmp       short M03_L07
M03_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L10:
       cmp       r13d,2
       je        near ptr M03_L23
M03_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M03_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M03_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M03_L13
       mov       r10,[rsp+38]
       jmp       short M03_L14
M03_L13:
       mov       rdx,7FF7AD3B9A20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M03_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L15:
       cmp       r13d,2
       je        near ptr M03_L26
       jmp       near ptr M03_L11
M03_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M03_L12
M03_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M03_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M03_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M03_L20
M03_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M03_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M03_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M03_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M03_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M03_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M03_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L25
M03_L24:
       mov       rdx,7FF7AD3B9A38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FF7AD3B9A38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+120]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rbx,[rsp+28]
       mov       rbp,[rsp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD28CD18]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
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
       mov       rdx,7FF7AD3A7A08
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
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M02_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M02_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M02_L03
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3AA1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M02_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M02_L12
M02_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M02_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M02_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M02_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3AA1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M02_L10
M02_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L08
       mov       r10,[rsp+20]
       jmp       short M02_L09
M02_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3AA188
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M02_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M02_L10:
       test      eax,eax
       jne       short M02_L13
M02_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M02_L17
       test      r15d,r15d
       jge       near ptr M02_L04
M02_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L13:
       test      r13d,r13d
       jge       short M02_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M02_L15
M02_L14:
       cmp       r13d,[rsp+3C]
       jae       short M02_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M02_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M03_L22
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M03_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rdx,7FF7AD3AA1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M03_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M03_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M03_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rdx,7FF7AD3AA1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M03_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M03_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M03_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M03_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M03_L09
M03_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],r8d
       jmp       short M03_L07
M03_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L10:
       cmp       r13d,2
       je        near ptr M03_L23
M03_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M03_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M03_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M03_L13
       mov       r10,[rsp+38]
       jmp       short M03_L14
M03_L13:
       mov       rdx,7FF7AD3AA188
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M03_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L15:
       cmp       r13d,2
       je        near ptr M03_L26
       jmp       near ptr M03_L11
M03_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M03_L12
M03_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M03_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M03_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M03_L20
M03_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M03_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M03_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M03_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M03_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M03_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M03_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L25
M03_L24:
       mov       rdx,7FF7AD3AA1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FF7AD3AA1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+120]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rbx,[rsp+28]
       mov       rbp,[rsp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD28CD18]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
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
       mov       rdx,7FF7AD3A7A20
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
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M02_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M02_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M02_L03
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3AA1E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M02_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M02_L12
M02_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M02_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M02_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M02_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3AA1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M02_L10
M02_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L08
       mov       r10,[rsp+20]
       jmp       short M02_L09
M02_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3AA1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M02_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M02_L10:
       test      eax,eax
       jne       short M02_L13
M02_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M02_L17
       test      r15d,r15d
       jge       near ptr M02_L04
M02_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L13:
       test      r13d,r13d
       jge       short M02_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M02_L15
M02_L14:
       cmp       r13d,[rsp+3C]
       jae       short M02_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M02_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M03_L22
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M03_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rdx,7FF7AD3AA1E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M03_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M03_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M03_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rdx,7FF7AD3AA1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M03_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M03_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M03_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M03_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M03_L09
M03_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],r8d
       jmp       short M03_L07
M03_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L10:
       cmp       r13d,2
       je        near ptr M03_L23
M03_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M03_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M03_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M03_L13
       mov       r10,[rsp+38]
       jmp       short M03_L14
M03_L13:
       mov       rdx,7FF7AD3AA1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M03_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L15:
       cmp       r13d,2
       je        near ptr M03_L26
       jmp       near ptr M03_L11
M03_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M03_L12
M03_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M03_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M03_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M03_L20
M03_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M03_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M03_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M03_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M03_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M03_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M03_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L25
M03_L24:
       mov       rdx,7FF7AD3AA1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FF7AD3AA1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+120]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rbx,[rsp+28]
       mov       rbp,[rsp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD29CD18]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
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
       mov       rdx,7FF7AD3B79E0
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
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M02_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M02_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M02_L03
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3BA1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M02_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M02_L12
M02_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M02_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M02_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M02_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3BA198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M02_L10
M02_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L08
       mov       r10,[rsp+20]
       jmp       short M02_L09
M02_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3BA160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M02_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M02_L10:
       test      eax,eax
       jne       short M02_L13
M02_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M02_L17
       test      r15d,r15d
       jge       near ptr M02_L04
M02_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L13:
       test      r13d,r13d
       jge       short M02_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M02_L15
M02_L14:
       cmp       r13d,[rsp+3C]
       jae       short M02_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M02_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M03_L22
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M03_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rdx,7FF7AD3BA1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M03_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M03_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M03_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rdx,7FF7AD3BA198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M03_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M03_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M03_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M03_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M03_L09
M03_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],r8d
       jmp       short M03_L07
M03_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L10:
       cmp       r13d,2
       je        near ptr M03_L23
M03_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M03_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M03_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M03_L13
       mov       r10,[rsp+38]
       jmp       short M03_L14
M03_L13:
       mov       rdx,7FF7AD3BA160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M03_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L15:
       cmp       r13d,2
       je        near ptr M03_L26
       jmp       near ptr M03_L11
M03_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M03_L12
M03_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M03_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M03_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M03_L20
M03_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M03_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M03_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M03_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M03_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M03_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M03_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L25
M03_L24:
       mov       rdx,7FF7AD3BA178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FF7AD3BA178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+120]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rbx,[rsp+28]
       mov       rbp,[rsp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD2ACD18]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
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
       mov       rdx,7FF7AD3C79E0
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
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M02_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M02_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M02_L03
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3CA1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M02_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M02_L12
M02_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M02_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M02_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M02_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3CA198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M02_L10
M02_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L08
       mov       r10,[rsp+20]
       jmp       short M02_L09
M02_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3CA160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M02_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M02_L10:
       test      eax,eax
       jne       short M02_L13
M02_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M02_L17
       test      r15d,r15d
       jge       near ptr M02_L04
M02_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L13:
       test      r13d,r13d
       jge       short M02_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M02_L15
M02_L14:
       cmp       r13d,[rsp+3C]
       jae       short M02_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M02_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M03_L22
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M03_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rdx,7FF7AD3CA1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M03_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M03_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M03_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rdx,7FF7AD3CA198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M03_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M03_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M03_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M03_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M03_L09
M03_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],r8d
       jmp       short M03_L07
M03_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L10:
       cmp       r13d,2
       je        near ptr M03_L23
M03_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M03_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M03_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M03_L13
       mov       r10,[rsp+38]
       jmp       short M03_L14
M03_L13:
       mov       rdx,7FF7AD3CA160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M03_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L15:
       cmp       r13d,2
       je        near ptr M03_L26
       jmp       near ptr M03_L11
M03_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M03_L12
M03_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M03_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M03_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M03_L20
M03_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M03_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M03_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M03_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M03_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M03_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M03_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L25
M03_L24:
       mov       rdx,7FF7AD3CA178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FF7AD3CA178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+120]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rbx,[rsp+28]
       mov       rbp,[rsp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD28CD18]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
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
       mov       rdx,7FF7AD3A7A08
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
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M02_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M02_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M02_L03
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3AA1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M02_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M02_L12
M02_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M02_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M02_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M02_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3AA1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M02_L10
M02_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L08
       mov       r10,[rsp+20]
       jmp       short M02_L09
M02_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3AA188
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M02_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M02_L10:
       test      eax,eax
       jne       short M02_L13
M02_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M02_L17
       test      r15d,r15d
       jge       near ptr M02_L04
M02_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L13:
       test      r13d,r13d
       jge       short M02_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M02_L15
M02_L14:
       cmp       r13d,[rsp+3C]
       jae       short M02_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M02_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M03_L22
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M03_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rdx,7FF7AD3AA1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M03_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M03_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M03_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rdx,7FF7AD3AA1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M03_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M03_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M03_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M03_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M03_L09
M03_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],r8d
       jmp       short M03_L07
M03_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L10:
       cmp       r13d,2
       je        near ptr M03_L23
M03_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M03_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M03_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M03_L13
       mov       r10,[rsp+38]
       jmp       short M03_L14
M03_L13:
       mov       rdx,7FF7AD3AA188
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M03_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L15:
       cmp       r13d,2
       je        near ptr M03_L26
       jmp       near ptr M03_L11
M03_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M03_L12
M03_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M03_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M03_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M03_L20
M03_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M03_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M03_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M03_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M03_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M03_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M03_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L25
M03_L24:
       mov       rdx,7FF7AD3AA1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FF7AD3AA1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
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
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       r8,[rsi+120]
       mov       rdi,r8
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Linq.Enumerable.Last(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Last[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rbx,[rsp+28]
       mov       rbp,[rsp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD29CD18]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
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
       mov       rdx,7FF7AD3B7A38
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
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L16
       cmp       qword ptr [rsi+8],0
       je        near ptr M02_L12
       xor       ebx,ebx
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       short M02_L00
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       short M02_L03
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       r11,[r15+60]
       test      r11,r11
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FF7AD3BA200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L02:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r14d,eax
M02_L03:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r14d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L18
       movsxd    rdx,eax
       lea       rbp,[rcx+rdx*4+10]
       mov       r12,[rsi+10]
       mov       r13d,0FFFFFFFF
       mov       r15d,[rbp]
       dec       r15d
       test      r15d,r15d
       jl        near ptr M02_L12
M02_L04:
       mov       eax,[r12+8]
       mov       [rsp+3C],eax
       cmp       r15d,eax
       jae       near ptr M02_L18
       movsxd    rcx,r15d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8+10],r14d
       jne       near ptr M02_L11
       mov       r9,[rsi+18]
       mov       [rsp+28],r9
       test      r9,r9
       jne       short M02_L07
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FF7AD3BA1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       r9,[rsp+30]
       mov       rdx,[r9]
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M02_L10
M02_L07:
       mov       r9,[rsp+28]
       mov       r8,[rsp+30]
       mov       r10,[r8]
       mov       [rsp+20],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L08
       mov       r10,[rsp+20]
       jmp       short M02_L09
M02_L08:
       mov       [rsp+28],r9
       mov       rdx,7FF7AD3BA1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r9,[rsp+28]
       mov       r10,[rsp+20]
M02_L09:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
M02_L10:
       test      eax,eax
       jne       short M02_L13
M02_L11:
       mov       r13d,r15d
       mov       r8,[rsp+30]
       mov       r15d,[r8+14]
       inc       ebx
       cmp       [rsp+3C],ebx
       jb        near ptr M02_L17
       test      r15d,r15d
       jge       near ptr M02_L04
M02_L12:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L13:
       test      r13d,r13d
       jge       short M02_L14
       mov       r8,[rsp+30]
       mov       eax,[r8+14]
       inc       eax
       mov       [rbp],eax
       jmp       short M02_L15
M02_L14:
       cmp       r13d,[rsp+3C]
       jae       short M02_L18
       movsxd    rax,r13d
       lea       rax,[rax+rax*2]
       mov       r8,[rsp+30]
       mov       ecx,[r8+14]
       mov       [r12+rax*8+24],ecx
M02_L15:
       mov       eax,[rsi+3C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r8+14],eax
       xor       eax,eax
       mov       [r8],rax
       mov       [r8+8],rax
       mov       [rsi+3C],r15d
       inc       dword ptr [rsi+40]
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L17:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       test      rdi,rdi
       je        near ptr M03_L22
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M03_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rdx,7FF7AD3BA200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M03_L02:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M03_L04
M03_L03:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M03_L04:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       eax,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M03_L30
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+50],rax
       mov       r8d,[rax]
       dec       r8d
       mov       [rsp+5C],r8d
       test      r15,r15
       jne       near ptr M03_L12
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rdx,7FF7AD3BA1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M03_L06:
       mov       rcx,rdx
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
M03_L07:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r10d,[rsp+5C]
       cmp       r9d,r10d
       jbe       near ptr M03_L17
       movsxd    rdx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+30],r11
       cmp       [r11+10],r12d
       jne       short M03_L08
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rax
       mov       r8,rdi
       mov       [rsp+40],rax
       mov       r10,[rax]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       test      eax,eax
       mov       rax,[rsp+40]
       jne       short M03_L09
M03_L08:
       mov       r11,[rsp+30]
       mov       r10d,[r11+14]
       mov       r8d,r10d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],r8d
       jmp       short M03_L07
M03_L09:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L10
       mov       r11,[rsp+30]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L10:
       cmp       r13d,2
       je        near ptr M03_L23
M03_L11:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       mov       r9d,[r14+8]
       mov       [rsp+58],r9d
       mov       r8d,[rsp+5C]
       cmp       r9d,r8d
       jbe       near ptr M03_L17
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+10],r12d
       jne       short M03_L16
       mov       r10,[r14+rcx*8+10]
       mov       [rsp+38],r10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M03_L13
       mov       r10,[rsp+38]
       jmp       short M03_L14
M03_L13:
       mov       rdx,7FF7AD3BA1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r10,[rsp+38]
M03_L14:
       mov       rcx,r15
       mov       rdx,r10
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L16
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M03_L15
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L21
M03_L15:
       cmp       r13d,2
       je        near ptr M03_L26
       jmp       near ptr M03_L11
M03_L16:
       mov       r8,[rsp+28]
       mov       r8d,[r8+14]
       mov       ecx,r8d
       inc       r13d
       cmp       [rsp+58],r13d
       jb        near ptr M03_L29
       mov       [rsp+5C],ecx
       jmp       near ptr M03_L12
M03_L17:
       mov       ecx,[rsi+40]
       test      ecx,ecx
       jle       short M03_L18
       mov       edx,[rsi+3C]
       mov       ebp,edx
       cmp       edx,[rsp+58]
       jae       near ptr M03_L30
       movsxd    r9,edx
       lea       rdx,[r9+r9*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       ecx
       mov       [rsi+40],ecx
       jmp       short M03_L20
M03_L18:
       mov       ecx,[rsi+38]
       mov       ebp,ecx
       cmp       [rsp+58],ebp
       jne       short M03_L19
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L30
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r14,rax
       mov       [rsp+50],r14
M03_L19:
       lea       edx,[rbp+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L20:
       cmp       ebp,[r14+8]
       jae       near ptr M03_L30
       movsxd    rdx,ebp
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r14+rdx*8+10]
       mov       [r8+10],r12d
       mov       rax,[rsp+50]
       mov       edx,[rax]
       dec       edx
       mov       [r8+14],edx
       mov       [rsp+48],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rsp+48]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+50]
       mov       [rdi],ebp
       inc       dword ptr [rsi+44]
       cmp       r13d,64
       jbe       short M03_L21
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M03_L21
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M03_L21:
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L22:
       mov       ecx,4
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L23:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L24
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L25
M03_L24:
       mov       rdx,7FF7AD3BA1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L25:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L26:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+50],0
       je        short M03_L27
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FF7AD3BA1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L28:
       mov       rdx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       int       3
M03_L29:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1087
```

