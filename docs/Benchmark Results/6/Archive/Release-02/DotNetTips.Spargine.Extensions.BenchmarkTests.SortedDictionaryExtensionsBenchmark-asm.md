## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,[rsi+18]
       mov       esi,[rsi+2AC]
       test      rax,rax
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rdi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477533C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4792E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,[rsi+18]
       mov       esi,[rsi+2AC]
       test      rax,rax
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rdi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477433C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,[rsi+18]
       mov       esi,[rsi+2AC]
       test      rax,rax
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rdi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477533C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4792E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,[rsi+18]
       mov       esi,[rsi+2AC]
       test      rax,rax
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rdi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477433C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,[rsi+18]
       mov       esi,[rsi+2AC]
       test      rax,rax
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rdi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477433C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,[rsi+18]
       mov       esi,[rsi+2AC]
       test      rax,rax
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rdi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477633C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,[rsi+18]
       mov       esi,[rsi+2AC]
       test      rax,rax
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rdi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB4776AF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4794DE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB47260800
       call      qword ptr [7FFB478B0800]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB47260808
       call      qword ptr [7FFB478B0808]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB47260808
       call      qword ptr [7FFB478B0808]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,[rsi+18]
       mov       esi,[rsi+2AC]
       test      rax,rax
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,esi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rdi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB4775AF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793DE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB47250800
       call      qword ptr [7FFB478A0800]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB47250808
       call      qword ptr [7FFB478A0808]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB47250808
       call      qword ptr [7FFB478A0808]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+18]
       mov       rcx,2891996D2F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2891996D2E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2891996D2F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       [rsi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477333C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4790E288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
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
       vdivsd    xmm0,xmm0,[7FFB4789EF68]
       vucomisd  xmm0,qword ptr [7FFB4789EF70]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rdi
       mov       rdx,7FFB47920A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFA8],rbx
       mov       rcx,rbx
       mov       r11,7FFB472307F0
       call      qword ptr [7FFB478907F0]
       test      eax,eax
       je        short M04_L06
M04_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB47920B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+0FFD0]
       mov       [rbp+0FFB8],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M04_L05
       mov       rcx,rbx
       mov       r11,7FFB472307F0
       call      qword ptr [7FFB478907F0]
       test      eax,eax
       jne       short M04_L02
       jmp       short M04_L06
M04_L05:
       mov       dword ptr [rbp+0FFC4],1
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       r11,7FFB472307F8
       call      qword ptr [7FFB478907F8]
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       eax,[rbp+0FFC4]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp+0FFA8]
       test      rbx,rbx
       je        short M04_L12
       mov       rcx,rbx
       mov       r11,7FFB472307F8
       call      qword ptr [7FFB478907F8]
M04_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+18]
       mov       rcx,290F4EED2F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,290F4EED2E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,290F4EED2F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       [rsi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477433C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791E288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
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
       vdivsd    xmm0,xmm0,[7FFB478AEF88]
       vucomisd  xmm0,qword ptr [7FFB478AEF90]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rdi
       mov       rdx,7FFB47930A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFA8],rbx
       mov       rcx,rbx
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       je        short M04_L06
M04_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB47930B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+0FFD0]
       mov       [rbp+0FFB8],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M04_L05
       mov       rcx,rbx
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       jne       short M04_L02
       jmp       short M04_L06
M04_L05:
       mov       dword ptr [rbp+0FFC4],1
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       eax,[rbp+0FFC4]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp+0FFA8]
       test      rbx,rbx
       je        short M04_L12
       mov       rcx,rbx
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
M04_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+18]
       mov       rcx,1B35657D2F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B35657D2E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1B35657D2F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       [rsi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477533C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4792E288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
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
       vdivsd    xmm0,xmm0,[7FFB478BF688]
       vucomisd  xmm0,qword ptr [7FFB478BF690]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rdi
       mov       rdx,7FFB47940AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFA8],rbx
       mov       rcx,rbx
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       je        short M04_L06
M04_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB47940B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+0FFD0]
       mov       [rbp+0FFB8],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M04_L05
       mov       rcx,rbx
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       jne       short M04_L02
       jmp       short M04_L06
M04_L05:
       mov       dword ptr [rbp+0FFC4],1
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       eax,[rbp+0FFC4]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp+0FFA8]
       test      rbx,rbx
       je        short M04_L12
       mov       rcx,rbx
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
M04_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+18]
       mov       rcx,1C2A4DB2FC8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C2A4DB2FC0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1C2A4DB2FC8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       [rsi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477433C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791E288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
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
       vdivsd    xmm0,xmm0,[7FFB478B2738]
       vucomisd  xmm0,qword ptr [7FFB478B2740]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rdi
       mov       rdx,7FFB47930AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFA8],rbx
       mov       rcx,rbx
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       je        short M04_L06
M04_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB47930B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+0FFD0]
       mov       [rbp+0FFB8],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M04_L05
       mov       rcx,rbx
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       jne       short M04_L02
       jmp       short M04_L06
M04_L05:
       mov       dword ptr [rbp+0FFC4],1
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       eax,[rbp+0FFC4]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp+0FFA8]
       test      rbx,rbx
       je        short M04_L12
       mov       rcx,rbx
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
M04_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+18]
       mov       rcx,1AFF335D2F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1AFF335D2E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1AFF335D2F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       [rsi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477433C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791E288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
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
       vdivsd    xmm0,xmm0,[7FFB478B2738]
       vucomisd  xmm0,qword ptr [7FFB478B2740]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rdi
       mov       rdx,7FFB47930AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFA8],rbx
       mov       rcx,rbx
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       je        short M04_L06
M04_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB47930B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+0FFD0]
       mov       [rbp+0FFB8],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M04_L05
       mov       rcx,rbx
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       jne       short M04_L02
       jmp       short M04_L06
M04_L05:
       mov       dword ptr [rbp+0FFC4],1
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       eax,[rbp+0FFC4]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp+0FFA8]
       test      rbx,rbx
       je        short M04_L12
       mov       rcx,rbx
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
M04_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+18]
       mov       rcx,24A9D59D2F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24A9D59D2E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,24A9D59D2F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       [rsi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477733C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4794E288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
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
       vdivsd    xmm0,xmm0,[7FFB478E2758]
       vucomisd  xmm0,qword ptr [7FFB478E2760]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rdi
       mov       rdx,7FFB47960AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFA8],rbx
       mov       rcx,rbx
       mov       r11,7FFB472707F0
       call      qword ptr [7FFB478D07F0]
       test      eax,eax
       je        short M04_L06
M04_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB47960B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+0FFD0]
       mov       [rbp+0FFB8],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M04_L05
       mov       rcx,rbx
       mov       r11,7FFB472707F0
       call      qword ptr [7FFB478D07F0]
       test      eax,eax
       jne       short M04_L02
       jmp       short M04_L06
M04_L05:
       mov       dword ptr [rbp+0FFC4],1
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       r11,7FFB472707F8
       call      qword ptr [7FFB478D07F8]
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       eax,[rbp+0FFC4]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp+0FFA8]
       test      rbx,rbx
       je        short M04_L12
       mov       rcx,rbx
       mov       r11,7FFB472707F8
       call      qword ptr [7FFB478D07F8]
M04_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+18]
       mov       rcx,15202022FC8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,15202022FC0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,15202022FC8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       [rsi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB4775AF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793E010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
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
       vdivsd    xmm0,xmm0,[7FFB478C1928]
       vucomisd  xmm0,qword ptr [7FFB478C1930]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rdi
       mov       rdx,7FFB47950810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFA8],rbx
       mov       rcx,rbx
       mov       r11,7FFB47250800
       call      qword ptr [7FFB478A0800]
       test      eax,eax
       je        short M04_L06
M04_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB479508E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+0FFD0]
       mov       [rbp+0FFB8],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M04_L05
       mov       rcx,rbx
       mov       r11,7FFB47250800
       call      qword ptr [7FFB478A0800]
       test      eax,eax
       jne       short M04_L02
       jmp       short M04_L06
M04_L05:
       mov       dword ptr [rbp+0FFC4],1
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       r11,7FFB47250808
       call      qword ptr [7FFB478A0808]
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       eax,[rbp+0FFC4]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp+0FFA8]
       test      rbx,rbx
       je        short M04_L12
       mov       rcx,rbx
       mov       r11,7FFB47250808
       call      qword ptr [7FFB478A0808]
M04_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rsi,[rsi+18]
       mov       rcx,193651ED2F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,193651ED2E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,193651ED2F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       [rsi+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB4773AF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791E040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__3_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
; 			this.Consumer.Consume(people.HasItems(p => p.Value.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
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
       vdivsd    xmm0,xmm0,[7FFB478A3148]
       vucomisd  xmm0,qword ptr [7FFB478A3150]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M04_L00
       jmp       short M04_L01
M04_L00:
       mov       rcx,rdi
       mov       rdx,7FFB47930848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFA8],rbx
       mov       rcx,rbx
       mov       r11,7FFB47230800
       call      qword ptr [7FFB47880800]
       test      eax,eax
       je        short M04_L06
M04_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB47930920
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp+0FFC8]
       mov       [rbp+0FFB0],rcx
       mov       rcx,[rbp+0FFD0]
       mov       [rbp+0FFB8],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M04_L05
       mov       rcx,rbx
       mov       r11,7FFB47230800
       call      qword ptr [7FFB47880800]
       test      eax,eax
       jne       short M04_L02
       jmp       short M04_L06
M04_L05:
       mov       dword ptr [rbp+0FFC4],1
       jmp       short M04_L07
M04_L06:
       mov       rcx,rbx
       mov       r11,7FFB47230808
       call      qword ptr [7FFB47880808]
       jmp       short M04_L08
M04_L07:
       mov       rcx,rsp
       call      M04_L11
       nop
       mov       eax,[rbp+0FFC4]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M04_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp+0FFA8]
       test      rbx,rbx
       je        short M04_L12
       mov       rcx,rbx
       mov       r11,7FFB47230808
       call      qword ptr [7FFB47880808]
M04_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
       test      rax,rax
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477433C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472407F8
       call      qword ptr [7FFB478A07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
       test      rax,rax
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477633C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
       test      rax,rax
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477633C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
       test      rax,rax
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477533C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4792E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
       test      rax,rax
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477633C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
       test      rax,rax
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477633C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
       test      rax,rax
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB4774AF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4792DE10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB47240800
       call      qword ptr [7FFB47890800]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB47240808
       call      qword ptr [7FFB47890808]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB47240808
       call      qword ptr [7FFB47890808]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
       test      rax,rax
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB4773AF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4791DE10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB47230800
       call      qword ptr [7FFB47880800]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB47230808
       call      qword ptr [7FFB47880808]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB47230808
       call      qword ptr [7FFB47880808]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
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
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477633C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472607F8
       call      qword ptr [7FFB478C07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
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
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477733C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4794E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472707F0
       call      qword ptr [7FFB478D07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472707F8
       call      qword ptr [7FFB478D07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472707F8
       call      qword ptr [7FFB478D07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
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
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477333C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4790E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472307F0
       call      qword ptr [7FFB478907F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472307F8
       call      qword ptr [7FFB478907F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472307F8
       call      qword ptr [7FFB478907F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
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
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477333C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4790E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472307F0
       call      qword ptr [7FFB478907F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472307F8
       call      qword ptr [7FFB478907F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472307F8
       call      qword ptr [7FFB478907F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
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
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477533C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4792E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472507F8
       call      qword ptr [7FFB478B07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
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
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB477733C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4794E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB472707F0
       call      qword ptr [7FFB478D07F0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB472707F8
       call      qword ptr [7FFB478D07F8]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB472707F8
       call      qword ptr [7FFB478D07F8]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
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
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB4775AF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4793DE10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB47250800
       call      qword ptr [7FFB478A0800]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB47250808
       call      qword ptr [7FFB478A0808]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB47250808
       call      qword ptr [7FFB478A0808]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
; 			var people = this.GetPersonProperRefDictionary().ToSortedDictionary();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+258]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary(System.Collections.Generic.Dictionary`2<!!0,!!1>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       rsi,[rsi+18]
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
       mov       [rsi+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB4776AF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rax,[rcx+10]
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB4794DE10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       xor       esi,esi
       mov       r11,7FFB47260800
       call      qword ptr [7FFB478B0800]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFB47260808
       call      qword ptr [7FFB478B0808]
       test      eax,eax
       je        short M03_L02
M03_L01:
       add       esi,1
       jo        short M03_L03
       mov       rcx,rdi
       mov       r11,7FFB47260808
       call      qword ptr [7FFB478B0808]
       test      eax,eax
       jne       short M03_L01
M03_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```

