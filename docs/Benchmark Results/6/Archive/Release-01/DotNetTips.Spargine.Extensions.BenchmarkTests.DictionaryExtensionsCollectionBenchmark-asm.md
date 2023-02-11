## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+28]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
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
       mov       rax,265292F1028
       mov       rbx,[rax]
       mov       rax,265392F15C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,265292F1028
       mov       r15,[rax]
       mov       rax,26519301040
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,26519301048
       mov       rcx,[rdx]
       mov       rdx,265392F1740
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L01:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,26519301050
       mov       rcx,[rdx]
       mov       rdx,265292F1270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbp
       mov       rdx,7FFAAF4A1BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFAAF4A1C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+20],rbx
M02_L07:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 342
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+28]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
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
       mov       rax,279F3C23020
       mov       rbx,[rax]
       mov       rax,279F3C31E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,279F3C23020
       mov       r15,[rax]
       mov       rax,279D3C21C00
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,279D3C21C08
       mov       rcx,[rdx]
       mov       rdx,279F3C31F78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L01:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,279D3C21C10
       mov       rcx,[rdx]
       mov       rdx,279F3C23268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbp
       mov       rdx,7FFAAF491BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFAAF491C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+20],rbx
M02_L07:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 342
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+28]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
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
       mov       rax,161F6E63020
       mov       rbx,[rax]
       mov       rax,16216E615C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,161F6E63020
       mov       r15,[rax]
       mov       rax,16216E62418
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,16216E62420
       mov       rcx,[rdx]
       mov       rdx,16216E61740
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L01:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,16216E62428
       mov       rcx,[rdx]
       mov       rdx,161F6E63268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbp
       mov       rdx,7FFAAF4A1BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFAAF4A1C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+20],rbx
M02_L07:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 342
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+28]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
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
       mov       rax,228666C3020
       mov       rbx,[rax]
       mov       rax,228866C15C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,228666C3020
       mov       r15,[rax]
       mov       rax,228666C6008
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,228666C6010
       mov       rcx,[rdx]
       mov       rdx,228866C1740
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L01:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,228666C6018
       mov       rcx,[rdx]
       mov       rdx,228666C3268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbp
       mov       rdx,7FFAAF481C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFAAF481CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+20],rbx
M02_L07:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 342
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+28]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
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
       mov       rax,2E687993020
       mov       rbx,[rax]
       mov       rax,2E6879A1E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,2E687993020
       mov       r15,[rax]
       mov       rax,2E6879A3C68
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,2E6879A3C70
       mov       rcx,[rdx]
       mov       rdx,2E6879A1F78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L01:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,2E6879A3C78
       mov       rcx,[rdx]
       mov       rdx,2E687993268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbp
       mov       rdx,7FFAAF4B1BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFAAF4B1C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+20],rbx
M02_L07:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 342
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+28]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
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
       mov       rax,1C1DF213020
       mov       rbx,[rax]
       mov       rax,1C1DF2159D0
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,1C1DF213020
       mov       r15,[rax]
       mov       rax,1C1DF216820
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,1C1DF216828
       mov       rcx,[rdx]
       mov       rdx,1C1DF215B48
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L01:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,1C1DF216830
       mov       rcx,[rdx]
       mov       rdx,1C1DF213268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbp
       mov       rdx,7FFAAF4A1BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFAAF4A1C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+20],rbx
M02_L07:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 342
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+28]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
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
       mov       rax,2E115AB1028
       mov       rbx,[rax]
       mov       rax,2E115ABFE08
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,2E115AB1028
       mov       r15,[rax]
       mov       rax,2E115AC1C70
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,2E115AC1C78
       mov       rcx,[rdx]
       mov       rdx,2E115ABFF80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L01:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,2E115AC1C80
       mov       rcx,[rdx]
       mov       rdx,2E115AB1270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbp
       mov       rdx,7FFAAF481BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFAAF481C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+20],rbx
M02_L07:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 342
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+28]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
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
       mov       rax,15397A53020
       mov       rbx,[rax]
       mov       rax,15397A61E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,15397A53020
       mov       r15,[rax]
       mov       rax,15377A52C18
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,15377A52C20
       mov       rcx,[rdx]
       mov       rdx,15397A61F78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L01:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       mov       edx,eax
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rdx,15377A52C28
       mov       rcx,[rdx]
       mov       rdx,15397A53268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbp
       mov       rdx,7FFAAF4E1BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFAAF4E1C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+20],rbx
M02_L07:
       mov       rax,[rsp+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 342
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var people = base.GetPersonProperDictionary(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF40],xmm4
       vmovdqa   xmmword ptr [rbp+0FF50],xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAF465B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       mov       r9,246E5533020
       mov       r9,[r9]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       test      eax,eax
       jne       short M01_L03
       mov       rax,246E5533020
       mov       rax,[rax]
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFA0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFB8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       vmovdqu   xmmword ptr [rbp+0FF60],xmm0
       mov       [rbp+0FF70],rcx
       mov       [rbp+0FF50],rcx
       mov       rcx,246E5532EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFAAF3E80E0]
       lea       rcx,[rbp+0FF50]
       mov       [rbp+0FF58],rax
       test      rax,rax
       jne       short M01_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L06
M01_L05:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M01_L06:
       add       rcx,18
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       xor       ecx,ecx
       mov       [rbp+0FF60],ecx
       mov       byte ptr [rbp+0FF64],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF60]
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       rcx,[rbp+0FF70]
       mov       [rbp+0FF98],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF466180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF78]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF90]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF88]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF88],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,246E5533298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       short M01_L11
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rdx,7FFAAF466258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF78]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF88]
       mov       ecx,edx
       mov       eax,[rbp+0FF98]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF90]
       mov       [rbp+0FF40],rcx
       mov       [rbp+0FF48],edx
       lea       rdx,[rbp+0FF40]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF80]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       [rbp+0FF98],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFAAF3E80E8]
M01_L13:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rdi],edi
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L14:
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        short M01_L17
M01_L15:
       lea       rcx,[rbp+0FFA0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF4660A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L19
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFAAF466350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FFA0]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFAAF466350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FFA0]
       call      rax
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
; Total bytes of code 1014
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var people = base.GetPersonProperDictionary(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF40],xmm4
       vmovdqa   xmmword ptr [rbp+0FF50],xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAF435B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       mov       r9,2D31E2E1028
       mov       r9,[r9]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       test      eax,eax
       jne       short M01_L03
       mov       rax,2D31E2E1028
       mov       rax,[rax]
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFA0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFB8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       vmovdqu   xmmword ptr [rbp+0FF60],xmm0
       mov       [rbp+0FF70],rcx
       mov       [rbp+0FF50],rcx
       mov       rcx,2D32E2E2EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFAAF3B80E0]
       lea       rcx,[rbp+0FF50]
       mov       [rbp+0FF58],rax
       test      rax,rax
       jne       short M01_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L06
M01_L05:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M01_L06:
       add       rcx,18
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       xor       ecx,ecx
       mov       [rbp+0FF60],ecx
       mov       byte ptr [rbp+0FF64],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF60]
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       rcx,[rbp+0FF70]
       mov       [rbp+0FF98],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF436180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF78]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF90]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF88]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF88],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,2D31E2E12A0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       short M01_L11
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rdx,7FFAAF436258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF78]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF88]
       mov       ecx,edx
       mov       eax,[rbp+0FF98]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF90]
       mov       [rbp+0FF40],rcx
       mov       [rbp+0FF48],edx
       lea       rdx,[rbp+0FF40]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF80]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       [rbp+0FF98],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFAAF3B80E8]
M01_L13:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rdi],edi
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L14:
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        short M01_L17
M01_L15:
       lea       rcx,[rbp+0FFA0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF4360A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L19
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFAAF436350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FFA0]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFAAF436350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FFA0]
       call      rax
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
; Total bytes of code 1014
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var people = base.GetPersonProperDictionary(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF40],xmm4
       vmovdqa   xmmword ptr [rbp+0FF50],xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAF445B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       mov       r9,19BB0AA3020
       mov       r9,[r9]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       test      eax,eax
       jne       short M01_L03
       mov       rax,19BB0AA3020
       mov       rax,[rax]
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFA0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFB8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       vmovdqu   xmmword ptr [rbp+0FF60],xmm0
       mov       [rbp+0FF70],rcx
       mov       [rbp+0FF50],rcx
       mov       rcx,19BB0AA2EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFAAF3C80E0]
       lea       rcx,[rbp+0FF50]
       mov       [rbp+0FF58],rax
       test      rax,rax
       jne       short M01_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L06
M01_L05:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M01_L06:
       add       rcx,18
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       xor       ecx,ecx
       mov       [rbp+0FF60],ecx
       mov       byte ptr [rbp+0FF64],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF60]
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       rcx,[rbp+0FF70]
       mov       [rbp+0FF98],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF446180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF78]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF90]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF88]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF88],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,19BB0AA3298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       short M01_L11
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rdx,7FFAAF446258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF78]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF88]
       mov       ecx,edx
       mov       eax,[rbp+0FF98]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF90]
       mov       [rbp+0FF40],rcx
       mov       [rbp+0FF48],edx
       lea       rdx,[rbp+0FF40]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF80]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       [rbp+0FF98],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFAAF3C80E8]
M01_L13:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rdi],edi
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L14:
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        short M01_L17
M01_L15:
       lea       rcx,[rbp+0FFA0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF4460A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L19
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFAAF446350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FFA0]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFAAF446350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FFA0]
       call      rax
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
; Total bytes of code 1014
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var people = base.GetPersonProperDictionary(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF40],xmm4
       vmovdqa   xmmword ptr [rbp+0FF50],xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAF455B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       mov       r9,180352D3020
       mov       r9,[r9]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       test      eax,eax
       jne       short M01_L03
       mov       rax,180352D3020
       mov       rax,[rax]
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFA0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFB8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       vmovdqu   xmmword ptr [rbp+0FF60],xmm0
       mov       [rbp+0FF70],rcx
       mov       [rbp+0FF50],rcx
       mov       rcx,180352D2EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFAAF3D80E0]
       lea       rcx,[rbp+0FF50]
       mov       [rbp+0FF58],rax
       test      rax,rax
       jne       short M01_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L06
M01_L05:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M01_L06:
       add       rcx,18
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       xor       ecx,ecx
       mov       [rbp+0FF60],ecx
       mov       byte ptr [rbp+0FF64],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF60]
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       rcx,[rbp+0FF70]
       mov       [rbp+0FF98],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF456180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF78]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF90]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF88]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF88],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,180352D3298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       short M01_L11
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rdx,7FFAAF456258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF78]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF88]
       mov       ecx,edx
       mov       eax,[rbp+0FF98]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF90]
       mov       [rbp+0FF40],rcx
       mov       [rbp+0FF48],edx
       lea       rdx,[rbp+0FF40]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF80]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       [rbp+0FF98],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFAAF3D80E8]
M01_L13:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rdi],edi
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L14:
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        short M01_L17
M01_L15:
       lea       rcx,[rbp+0FFA0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF4560A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L19
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFAAF456350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FFA0]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFAAF456350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FFA0]
       call      rax
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
; Total bytes of code 1014
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var people = base.GetPersonProperDictionary(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF40],xmm4
       vmovdqa   xmmword ptr [rbp+0FF50],xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAF445B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       mov       r9,28757863020
       mov       r9,[r9]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       test      eax,eax
       jne       short M01_L03
       mov       rax,28757863020
       mov       rax,[rax]
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFA0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFB8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       vmovdqu   xmmword ptr [rbp+0FF60],xmm0
       mov       [rbp+0FF70],rcx
       mov       [rbp+0FF50],rcx
       mov       rcx,28757862EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFAAF3C80E0]
       lea       rcx,[rbp+0FF50]
       mov       [rbp+0FF58],rax
       test      rax,rax
       jne       short M01_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L06
M01_L05:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M01_L06:
       add       rcx,18
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       xor       ecx,ecx
       mov       [rbp+0FF60],ecx
       mov       byte ptr [rbp+0FF64],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF60]
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       rcx,[rbp+0FF70]
       mov       [rbp+0FF98],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF446180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF78]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF90]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF88]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF88],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,28757863298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       short M01_L11
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rdx,7FFAAF446258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF78]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF88]
       mov       ecx,edx
       mov       eax,[rbp+0FF98]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF90]
       mov       [rbp+0FF40],rcx
       mov       [rbp+0FF48],edx
       lea       rdx,[rbp+0FF40]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF80]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       [rbp+0FF98],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFAAF3C80E8]
M01_L13:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rdi],edi
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L14:
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        short M01_L17
M01_L15:
       lea       rcx,[rbp+0FFA0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF4460A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L19
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFAAF446350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FFA0]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFAAF446350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FFA0]
       call      rax
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
; Total bytes of code 1014
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var people = base.GetPersonProperDictionary(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF40],xmm4
       vmovdqa   xmmword ptr [rbp+0FF50],xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAF435AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       mov       r9,1666C653020
       mov       r9,[r9]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       test      eax,eax
       jne       short M01_L03
       mov       rax,1666C653020
       mov       rax,[rax]
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFA0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFB8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       vmovdqu   xmmword ptr [rbp+0FF60],xmm0
       mov       [rbp+0FF70],rcx
       mov       [rbp+0FF50],rcx
       mov       rcx,1666C652EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFAAF3B80E0]
       lea       rcx,[rbp+0FF50]
       mov       [rbp+0FF58],rax
       test      rax,rax
       jne       short M01_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L06
M01_L05:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M01_L06:
       add       rcx,18
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       xor       ecx,ecx
       mov       [rbp+0FF60],ecx
       mov       byte ptr [rbp+0FF64],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF60]
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       rcx,[rbp+0FF70]
       mov       [rbp+0FF98],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF436138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF78]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF90]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF88]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF88],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,1666C653298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       short M01_L11
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rdx,7FFAAF436210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF78]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF88]
       mov       ecx,edx
       mov       eax,[rbp+0FF98]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF90]
       mov       [rbp+0FF40],rcx
       mov       [rbp+0FF48],edx
       lea       rdx,[rbp+0FF40]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF80]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       [rbp+0FF98],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFAAF3B80E8]
M01_L13:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rdi],edi
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L14:
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        short M01_L17
M01_L15:
       lea       rcx,[rbp+0FFA0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF436060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L19
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFAAF436308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FFA0]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFAAF436308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FFA0]
       call      rax
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
; Total bytes of code 1014
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var people = base.GetPersonProperDictionary(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF40],xmm4
       vmovdqa   xmmword ptr [rbp+0FF50],xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAF455AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       mov       r9,1A467493020
       mov       r9,[r9]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       test      eax,eax
       jne       short M01_L03
       mov       rax,1A467493020
       mov       rax,[rax]
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFA0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFB8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       vmovdqu   xmmword ptr [rbp+0FF60],xmm0
       mov       [rbp+0FF70],rcx
       mov       [rbp+0FF50],rcx
       mov       rcx,1A467492EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFAAF3D80E0]
       lea       rcx,[rbp+0FF50]
       mov       [rbp+0FF58],rax
       test      rax,rax
       jne       short M01_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L06
M01_L05:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M01_L06:
       add       rcx,18
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       xor       ecx,ecx
       mov       [rbp+0FF60],ecx
       mov       byte ptr [rbp+0FF64],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF60]
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       rcx,[rbp+0FF70]
       mov       [rbp+0FF98],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF456138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF78]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF90]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF88]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF88],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,1A467493298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       short M01_L11
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rdx,7FFAAF456210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF78]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF88]
       mov       ecx,edx
       mov       eax,[rbp+0FF98]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF90]
       mov       [rbp+0FF40],rcx
       mov       [rbp+0FF48],edx
       lea       rdx,[rbp+0FF40]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF80]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       [rbp+0FF98],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFAAF3D80E8]
M01_L13:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rdi],edi
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L14:
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        short M01_L17
M01_L15:
       lea       rcx,[rbp+0FFA0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF456060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L19
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFAAF456308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FFA0]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFAAF456308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FFA0]
       call      rax
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
; Total bytes of code 1014
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToDelimitedString01()
; 			var people = base.GetPersonProperDictionary(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = StringBuilderHelper.ToDelimitedString(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+20]
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF40],xmm4
       vmovdqa   xmmword ptr [rbp+0FF50],xmm4
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAF4795F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       mov       r9,121F0573020
       mov       r9,[r9]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.String)
       test      eax,eax
       jne       short M01_L03
       mov       rax,121F0573020
       mov       rax,[rax]
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp+0FFA0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFB8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       vmovdqu   xmmword ptr [rbp+0FF60],xmm0
       mov       [rbp+0FF70],rcx
       mov       [rbp+0FF50],rcx
       mov       rcx,121F0572EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFAAF3F80E0]
       lea       rcx,[rbp+0FF50]
       mov       [rbp+0FF58],rax
       test      rax,rax
       jne       short M01_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M01_L06
M01_L05:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M01_L06:
       add       rcx,18
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       xor       ecx,ecx
       mov       [rbp+0FF60],ecx
       mov       byte ptr [rbp+0FF64],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF60]
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       rcx,[rbp+0FF70]
       mov       [rbp+0FF98],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF479C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF78]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF90]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF88]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF88],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,121F0573298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],38
       jle       short M01_L11
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rdx,7FFAAF479D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF78]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF78]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF88]
       mov       ecx,edx
       mov       eax,[rbp+0FF98]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF90]
       mov       [rbp+0FF40],rcx
       mov       [rbp+0FF48],edx
       lea       rdx,[rbp+0FF40]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF80]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       vmovdqu   xmmword ptr [rbp+0FF88],xmm0
       mov       [rbp+0FF98],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFAAF3F80E8]
M01_L13:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rdi],edi
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L14:
       mov       rdx,[rbx+20]
       test      rdx,rdx
       je        short M01_L17
M01_L15:
       lea       rcx,[rbp+0FFA0]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFAAF479B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L19
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FFAAF479E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FFA0]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFAAF479E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FFA0]
       call      rax
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
; Total bytes of code 1014
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+28]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,180B9DF3020
       mov       rbx,[rax]
       mov       rax,180D9DFD9F8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,180B9DF3020
       mov       r15,[rax]
       mov       rax,180D9DFE848
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,180B9DF3020
       mov       r15,[rax]
       mov       rax,180D9DFDB70
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,180B9DF3020
       mov       r15,[rax]
       mov       rax,180B9DF3268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1C50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+28]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,25406E93020
       mov       rbx,[rax]
       mov       rax,25426E9D9F8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,25406E93020
       mov       r15,[rax]
       mov       rax,25406E97020
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,25406E93020
       mov       r15,[rax]
       mov       rax,25426E9DB70
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,25406E93020
       mov       r15,[rax]
       mov       rax,25406E93268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+28]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,2ADE7093020
       mov       rbx,[rax]
       mov       rax,2ADE70A1E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,2ADE7093020
       mov       r15,[rax]
       mov       rax,2ADE70A3C68
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,2ADE7093020
       mov       r15,[rax]
       mov       rax,2ADE70A1F78
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,2ADE7093020
       mov       r15,[rax]
       mov       rax,2ADE7093268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1C50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+28]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,264C54E3020
       mov       rbx,[rax]
       mov       rax,264E54E15C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,264C54E3020
       mov       r15,[rax]
       mov       rax,264C54F3450
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,264C54E3020
       mov       r15,[rax]
       mov       rax,264E54E1740
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,264C54E3020
       mov       r15,[rax]
       mov       rax,264C54E3268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF491B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF491C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF491C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+28]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,2464B0D3020
       mov       rbx,[rax]
       mov       rax,2466B0D15C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,2464B0D3020
       mov       r15,[rax]
       mov       rax,2467B0D1C00
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,2464B0D3020
       mov       r15,[rax]
       mov       rax,2466B0D1740
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,2464B0D3020
       mov       r15,[rax]
       mov       rax,2464B0D3268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A1C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+28]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,208B96A3020
       mov       rbx,[rax]
       mov       rax,208B96B1E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,208B96A3020
       mov       r15,[rax]
       mov       rax,208996A1C00
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,208B96A3020
       mov       r15,[rax]
       mov       rax,208B96B1F78
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,208B96A3020
       mov       r15,[rax]
       mov       rax,208B96A3268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4C1BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4C1C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4C1C50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+28]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,1A4418E3020
       mov       rbx,[rax]
       mov       rax,1A4418F1E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,1A4418E3020
       mov       r15,[rax]
       mov       rax,1A4218E2C18
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,1A4418E3020
       mov       r15,[rax]
       mov       rax,1A4418F1F78
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,1A4418E3020
       mov       r15,[rax]
       mov       rax,1A4418E3268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4C1BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4C1C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4C1C68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(this.PersonProper01.Id, this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+28]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,22CAF4B3020
       mov       rbx,[rax]
       mov       rax,22CCF4B15C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,22CAF4B3020
       mov       r15,[rax]
       mov       rax,22CCF4B2418
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,22CAF4B3020
       mov       r15,[rax]
       mov       rax,22CCF4B1740
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       mov       rax,22CAF4B3020
       mov       r15,[rax]
       mov       rax,22CAF4B3268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       cmp       qword ptr [r14+30],0
       je        short M02_L03
       mov       r11,[r14+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4D1B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4D1C50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4D1C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = people.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,1B645B13020
       mov       rbx,[rax]
       mov       rax,1B665B115C8
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
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD0],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M02_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF481A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF481EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF481C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF481EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M02_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF481ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       lea       r8d,[r14+0FFFF]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF481D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEDF0678
       call      qword ptr [7FFAAF3B0678]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF481D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFAAEDF0680
       call      qword ptr [7FFAAF3B0680]
       test      eax,eax
       jne       short M02_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rdx
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFA8],rcx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       r11,7FFAAEDF0688
       call      qword ptr [7FFAAF3B0688]
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsp
       call      M02_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+0FFB0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+0FFA8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp+0FFB8]
       test      rdi,rdi
       je        short M02_L22
       mov       rcx,rdi
       mov       r11,7FFAAEDF0688
       call      qword ptr [7FFAAF3B0688]
M02_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,1B645B13020
       mov       r15,[rax]
       mov       rax,1B645B22438
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,1B645B13020
       mov       r15,[rax]
       mov       rax,1B665B11740
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,1B645B13020
       mov       r15,[rax]
       mov       rax,1B645B13268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [r14+30],0
       je        short M03_L03
       mov       r11,[r14+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4824C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M03_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF482580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M03_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF482568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = people.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,2050ABB3020
       mov       rbx,[rax]
       mov       rax,2050ABC1E00
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
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD0],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M02_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M02_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       lea       r8d,[r14+0FFFF]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE10678
       call      qword ptr [7FFAAF3D0678]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFAAEE10680
       call      qword ptr [7FFAAF3D0680]
       test      eax,eax
       jne       short M02_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rdx
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFA8],rcx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       r11,7FFAAEE10688
       call      qword ptr [7FFAAF3D0688]
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsp
       call      M02_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+0FFB0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+0FFA8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp+0FFB8]
       test      rdi,rdi
       je        short M02_L22
       mov       rcx,rdi
       mov       r11,7FFAAEE10688
       call      qword ptr [7FFAAF3D0688]
M02_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,2050ABB3020
       mov       r15,[rax]
       mov       rax,204EABB1C00
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,2050ABB3020
       mov       r15,[rax]
       mov       rax,2050ABC1F78
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,2050ABB3020
       mov       r15,[rax]
       mov       rax,2050ABB3268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [r14+30],0
       je        short M03_L03
       mov       r11,[r14+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A24C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M03_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A2580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M03_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A2568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = people.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,188C2823020
       mov       rbx,[rax]
       mov       rax,188C28259D0
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
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD0],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M02_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M02_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       lea       r8d,[r14+0FFFF]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
       test      eax,eax
       jne       short M02_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rdx
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFA8],rcx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       r11,7FFAAEE20688
       call      qword ptr [7FFAAF3E0688]
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsp
       call      M02_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+0FFB0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+0FFA8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp+0FFB8]
       test      rdi,rdi
       je        short M02_L22
       mov       rcx,rdi
       mov       r11,7FFAAEE20688
       call      qword ptr [7FFAAF3E0688]
M02_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,188C2823020
       mov       r15,[rax]
       mov       rax,188C2827838
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,188C2823020
       mov       r15,[rax]
       mov       rax,188C2825B48
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,188C2823020
       mov       r15,[rax]
       mov       rax,188C2823268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [r14+30],0
       je        short M03_L03
       mov       r11,[r14+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4B24C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M03_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4B2580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M03_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4B2568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = people.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,2A0F9113020
       mov       rbx,[rax]
       mov       rax,2A0F9121E00
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
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD0],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M02_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF481A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF481EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF481C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF481EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M02_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF481ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       lea       r8d,[r14+0FFFF]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF481D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEDF0678
       call      qword ptr [7FFAAF3B0678]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF481D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFAAEDF0680
       call      qword ptr [7FFAAF3B0680]
       test      eax,eax
       jne       short M02_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rdx
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFA8],rcx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       r11,7FFAAEDF0688
       call      qword ptr [7FFAAF3B0688]
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsp
       call      M02_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+0FFB0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+0FFA8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp+0FFB8]
       test      rdi,rdi
       je        short M02_L22
       mov       rcx,rdi
       mov       r11,7FFAAEDF0688
       call      qword ptr [7FFAAF3B0688]
M02_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,2A0F9113020
       mov       r15,[rax]
       mov       rax,2A0D9112C18
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,2A0F9113020
       mov       r15,[rax]
       mov       rax,2A0F9121F78
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,2A0F9113020
       mov       r15,[rax]
       mov       rax,2A0F9113268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [r14+30],0
       je        short M03_L03
       mov       r11,[r14+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4824C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M03_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF482580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M03_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF482568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = people.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,1C50A423020
       mov       rbx,[rax]
       mov       rax,1C50A4259D0
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
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD0],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M02_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M02_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       lea       r8d,[r14+0FFFF]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4B1D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFAAEE20680
       call      qword ptr [7FFAAF3E0680]
       test      eax,eax
       jne       short M02_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rdx
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFA8],rcx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       r11,7FFAAEE20688
       call      qword ptr [7FFAAF3E0688]
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsp
       call      M02_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+0FFB0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+0FFA8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp+0FFB8]
       test      rdi,rdi
       je        short M02_L22
       mov       rcx,rdi
       mov       r11,7FFAAEE20688
       call      qword ptr [7FFAAF3E0688]
M02_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,1C50A423020
       mov       r15,[rax]
       mov       rax,1C50A426820
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,1C50A423020
       mov       r15,[rax]
       mov       rax,1C50A425B48
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,1C50A423020
       mov       r15,[rax]
       mov       rax,1C50A423268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [r14+30],0
       je        short M03_L03
       mov       r11,[r14+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4B24C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M03_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4B2580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M03_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4B2568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = people.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,2334B663020
       mov       rbx,[rax]
       mov       rax,2336B6615C8
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
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD0],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M02_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF491A58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF491F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF491C48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF491EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M02_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF491F08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       lea       r8d,[r14+0FFFF]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF491D78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE00678
       call      qword ptr [7FFAAF3C0678]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF491D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFAAEE00680
       call      qword ptr [7FFAAF3C0680]
       test      eax,eax
       jne       short M02_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rdx
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFA8],rcx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       r11,7FFAAEE00688
       call      qword ptr [7FFAAF3C0688]
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsp
       call      M02_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+0FFB0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+0FFA8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp+0FFB8]
       test      rdi,rdi
       je        short M02_L22
       mov       rcx,rdi
       mov       r11,7FFAAEE00688
       call      qword ptr [7FFAAF3C0688]
M02_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,2334B663020
       mov       r15,[rax]
       mov       rax,2334B666008
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,2334B663020
       mov       r15,[rax]
       mov       rax,2336B661740
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,2334B663020
       mov       r15,[rax]
       mov       rax,2334B663268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [r14+30],0
       je        short M03_L03
       mov       r11,[r14+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4924F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M03_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4925B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M03_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF492598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = people.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,23B188E3020
       mov       rbx,[rax]
       mov       rax,23B388E15C8
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
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD0],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M02_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1F38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1F08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M02_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       lea       r8d,[r14+0FFFF]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEE10678
       call      qword ptr [7FFAAF3D0678]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFAAEE10680
       call      qword ptr [7FFAAF3D0680]
       test      eax,eax
       jne       short M02_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rdx
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFA8],rcx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       r11,7FFAAEE10688
       call      qword ptr [7FFAAF3D0688]
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsp
       call      M02_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+0FFB0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+0FFA8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp+0FFB8]
       test      rdi,rdi
       je        short M02_L22
       mov       rcx,rdi
       mov       r11,7FFAAEE10688
       call      qword ptr [7FFAAF3D0688]
M02_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,23B188E3020
       mov       r15,[rax]
       mov       rax,23B188F2438
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,23B188E3020
       mov       r15,[rax]
       mov       rax,23B388E1740
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,23B188E3020
       mov       r15,[rax]
       mov       rax,23B188E3268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [r14+30],0
       je        short M03_L03
       mov       r11,[r14+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A2510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M03_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A25C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M03_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A25B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
; 			var people = base.GetPersonProperDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var person = people.Last();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			people.Upsert(person.Key, person.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdx,[rsi+100]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        short M00_L00
       mov       r8,[rsp+20]
       mov       r9,[rsp+28]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,24109B13020
       mov       rbx,[rax]
       mov       rax,24109B159D0
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
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD0],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M02_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M02_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1F08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M02_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M02_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       lea       r8d,[r14+0FFFF]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFAAEDF0678
       call      qword ptr [7FFAAF3C0678]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAF4A1D78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFAAEDF0680
       call      qword ptr [7FFAAF3C0680]
       test      eax,eax
       jne       short M02_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rdx
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFA8],rcx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rdi
       mov       r11,7FFAAEDF0688
       call      qword ptr [7FFAAF3C0688]
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsp
       call      M02_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+0FFB0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+0FFA8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp+0FFB8]
       test      rdi,rdi
       je        short M02_L22
       mov       rcx,rdi
       mov       r11,7FFAAEDF0688
       call      qword ptr [7FFAAF3C0688]
M02_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,24109B13020
       mov       r15,[rax]
       mov       rax,240E9B1ABB0
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,24109B13020
       mov       r15,[rax]
       mov       rax,24109B15B48
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       mov       rax,24109B13020
       mov       r15,[rax]
       mov       rax,24109B13268
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       cmp       qword ptr [r14+30],0
       je        short M03_L03
       mov       r11,[r14+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A24E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L04:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L07
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M03_L05
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A2598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M03_L07:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L08
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,7FFAAF4A2580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
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
; Total bytes of code 403
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

