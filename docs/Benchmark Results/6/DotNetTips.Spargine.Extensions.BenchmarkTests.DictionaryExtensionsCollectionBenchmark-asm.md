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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+18]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,26F120E1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,26F120EFE08
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rax,26F120E1028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       r14,[rbp+10]
       mov       rax,26F420E1A50
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       xor       eax,eax
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,26F420E1A58
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L01
       cmp       dword ptr [rdx+8],0
       je        short M02_L01
       mov       rcx,[rsp+38]
       jmp       short M02_L01
M02_L01:
       mov       rdx,26F120EFF80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,26F420E1A60
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L03
       cmp       dword ptr [rdx+8],0
       je        short M02_L03
       mov       rcx,[rsp+38]
       jmp       short M02_L03
M02_L03:
       mov       rdx,26F120E1270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L04:
       cmp       qword ptr [r14+30],0
       je        short M02_L05
       mov       r11,[r14+30]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFEBD003F00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       lea       r8,[rsp+40]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L07
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rbp
       mov       rdx,7FFEBD003FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [r11]
       mov       [rsp+40],rdi
M02_L09:
       mov       rax,[rsp+40]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 439
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+18]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1CA18363020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1CA18371E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rax,1CA18363020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       r14,[rbp+10]
       mov       rax,1CA18372AA0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       xor       eax,eax
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1CA18372AA8
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L01
       cmp       dword ptr [rdx+8],0
       je        short M02_L01
       mov       rcx,[rsp+38]
       jmp       short M02_L01
M02_L01:
       mov       rdx,1CA18371F78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1CA18372AB0
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L03
       cmp       dword ptr [rdx+8],0
       je        short M02_L03
       mov       rcx,[rsp+38]
       jmp       short M02_L03
M02_L03:
       mov       rdx,1CA18363268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L04:
       cmp       qword ptr [r14+30],0
       je        short M02_L05
       mov       r11,[r14+30]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFEBCF63C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       lea       r8,[rsp+40]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L07
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rbp
       mov       rdx,7FFEBCF63CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [r11]
       mov       [rsp+40],rdi
M02_L09:
       mov       rax,[rsp+40]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 439
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+18]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,24368C43020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,24368C459D0
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rax,24368C43020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       r14,[rbp+10]
       mov       rax,24388C41A50
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       xor       eax,eax
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,24388C41A58
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L01
       cmp       dword ptr [rdx+8],0
       je        short M02_L01
       mov       rcx,[rsp+38]
       jmp       short M02_L01
M02_L01:
       mov       rdx,24368C45B48
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,24388C41A60
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L03
       cmp       dword ptr [rdx+8],0
       je        short M02_L03
       mov       rcx,[rsp+38]
       jmp       short M02_L03
M02_L03:
       mov       rdx,24368C43268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L04:
       cmp       qword ptr [r14+30],0
       je        short M02_L05
       mov       r11,[r14+30]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFEBCF63BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       lea       r8,[rsp+40]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L07
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rbp
       mov       rdx,7FFEBCF63C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [r11]
       mov       [rsp+40],rdi
M02_L09:
       mov       rax,[rsp+40]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 439
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+18]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,2013FBD3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2015FBD9560
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rax,2013FBD3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       r14,[rbp+10]
       mov       rax,2015FBDB218
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       xor       eax,eax
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,2015FBDB220
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L01
       cmp       dword ptr [rdx+8],0
       je        short M02_L01
       mov       rcx,[rsp+38]
       jmp       short M02_L01
M02_L01:
       mov       rdx,2015FBD96D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,2015FBDB228
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L03
       cmp       dword ptr [rdx+8],0
       je        short M02_L03
       mov       rcx,[rsp+38]
       jmp       short M02_L03
M02_L03:
       mov       rdx,2013FBD3268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L04:
       cmp       qword ptr [r14+30],0
       je        short M02_L05
       mov       r11,[r14+30]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFEBCF63C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       lea       r8,[rsp+40]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L07
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rbp
       mov       rdx,7FFEBCF63CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [r11]
       mov       [rsp+40],rdi
M02_L09:
       mov       rax,[rsp+40]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 439
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+18]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1BAA9053020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1BAA90559D0
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rax,1BAA9053020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       r14,[rbp+10]
       mov       rax,1BAA9057688
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       xor       eax,eax
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1BAA9057690
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L01
       cmp       dword ptr [rdx+8],0
       je        short M02_L01
       mov       rcx,[rsp+38]
       jmp       short M02_L01
M02_L01:
       mov       rdx,1BAA9055B48
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1BAA9057698
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L03
       cmp       dword ptr [rdx+8],0
       je        short M02_L03
       mov       rcx,[rsp+38]
       jmp       short M02_L03
M02_L03:
       mov       rdx,1BAA9053268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L04:
       cmp       qword ptr [r14+30],0
       je        short M02_L05
       mov       r11,[r14+30]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFEBCF93BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       lea       r8,[rsp+40]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L07
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rbp
       mov       rdx,7FFEBCF93C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [r11]
       mov       [rsp+40],rdi
M02_L09:
       mov       rax,[rsp+40]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 439
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+18]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1DCB5823020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1DC958215C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rax,1DCB5823020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       r14,[rbp+10]
       mov       rax,1DCC5821A50
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       xor       eax,eax
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1DCC5821A58
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L01
       cmp       dword ptr [rdx+8],0
       je        short M02_L01
       mov       rcx,[rsp+38]
       jmp       short M02_L01
M02_L01:
       mov       rdx,1DC95821740
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1DCC5821A60
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L03
       cmp       dword ptr [rdx+8],0
       je        short M02_L03
       mov       rcx,[rsp+38]
       jmp       short M02_L03
M02_L03:
       mov       rdx,1DCB5823268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L04:
       cmp       qword ptr [r14+30],0
       je        short M02_L05
       mov       r11,[r14+30]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFEBCF93C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       lea       r8,[rsp+40]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L07
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rbp
       mov       rdx,7FFEBCF93CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [r11]
       mov       [rsp+40],rdi
M02_L09:
       mov       rax,[rsp+40]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 439
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+18]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1F93FFF3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1F94FFF15C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rax,1F93FFF3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       r14,[rbp+10]
       mov       rax,1F91FFF1A50
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       xor       eax,eax
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1F91FFF1A58
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L01
       cmp       dword ptr [rdx+8],0
       je        short M02_L01
       mov       rcx,[rsp+38]
       jmp       short M02_L01
M02_L01:
       mov       rdx,1F94FFF1740
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1F91FFF1A60
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L03
       cmp       dword ptr [rdx+8],0
       je        short M02_L03
       mov       rcx,[rsp+38]
       jmp       short M02_L03
M02_L03:
       mov       rdx,1F93FFF3268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L04:
       cmp       qword ptr [r14+30],0
       je        short M02_L05
       mov       r11,[r14+30]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFEBCF83BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       lea       r8,[rsp+40]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L07
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rbp
       mov       rdx,7FFEBCF83C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [r11]
       mov       [rsp+40],rdi
M02_L09:
       mov       rax,[rsp+40]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 439
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r9,[rsi+18]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       rcx,[rsi+10]
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
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rax,1EFD5273020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1EFD5281E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbp,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rax,1EFD5273020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       r14,[rbp+10]
       mov       rax,1EFF5272A68
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
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
       xor       eax,eax
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1EFF5272A70
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L01
       cmp       dword ptr [rdx+8],0
       je        short M02_L01
       mov       rcx,[rsp+38]
       jmp       short M02_L01
M02_L01:
       mov       rdx,1EFD5281F78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L02:
       test      rdi,rdi
       setne     al
       movzx     eax,al
       mov       edx,eax
       mov       rcx,1EFF5272A78
       mov       rcx,[rcx]
       mov       [rsp+38],rcx
       and       eax,edx
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorInvalidValue()
       mov       rcx,rax
       mov       rdx,[rsp+38]
       test      rdx,rdx
       je        short M02_L03
       cmp       dword ptr [rdx+8],0
       je        short M02_L03
       mov       rcx,[rsp+38]
       jmp       short M02_L03
M02_L03:
       mov       rdx,1EFD5273268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentInvalidException(System.String, System.String)
M02_L04:
       cmp       qword ptr [r14+30],0
       je        short M02_L05
       mov       r11,[r14+30]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbp
       mov       rdx,7FFEBCFF1C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       lea       r8,[rsp+40]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L07
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rbp
       mov       rdx,7FFEBCFF1CC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [r11]
       mov       [rsp+40],rdi
M02_L09:
       mov       rax,[rsp+40]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 439
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rdx,17E0C743020
       mov       rdx,[rdx]
       mov       [rbp+0FFB8],rdx
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFEBCF12220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       lea       r8,[rbp+0FFC0]
       lea       r9,[rbp+0FFB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M01_L03
       mov       rax,17E0C743020
       mov       rax,[rax]
       add       rsp,0D0
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
       lea       rdx,[rbp+0FF90]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFA8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF40],xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       mov       [rbp+0FF60],rcx
       mov       [rbp+0FF40],rcx
       mov       rcx,17E0C742EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFEBCD780E0]
       lea       rcx,[rbp+0FF40]
       mov       [rbp+0FF48],rax
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
       mov       [rbp+0FF50],ecx
       mov       byte ptr [rbp+0FF54],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF40]
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       rcx,[rbp+0FF60]
       mov       [rbp+0FF88],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF12898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF68]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF80]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF78]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF78],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,17E0C743298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF68]
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
       mov       rdx,7FFEBCF12970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF68]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF68]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF78]
       mov       ecx,edx
       mov       eax,[rbp+0FF88]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF80]
       mov       [rbp+0FF30],rcx
       mov       [rbp+0FF38],edx
       lea       rdx,[rbp+0FF30]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF70]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       [rbp+0FF88],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFEBCD780E8]
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
       lea       rcx,[rbp+0FF90]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF127C0
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
       mov       rdx,7FFEBCF12A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FF90]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0D0
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
       lea       rbp,[rbp+100]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFEBCF12A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FF90]
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
; Total bytes of code 1025
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rdx,25E46123020
       mov       rdx,[rdx]
       mov       [rbp+0FFB8],rdx
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFEBCF12220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       lea       r8,[rbp+0FFC0]
       lea       r9,[rbp+0FFB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M01_L03
       mov       rax,25E46123020
       mov       rax,[rax]
       add       rsp,0D0
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
       lea       rdx,[rbp+0FF90]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFA8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF40],xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       mov       [rbp+0FF60],rcx
       mov       [rbp+0FF40],rcx
       mov       rcx,25E46122EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFEBCD780E0]
       lea       rcx,[rbp+0FF40]
       mov       [rbp+0FF48],rax
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
       mov       [rbp+0FF50],ecx
       mov       byte ptr [rbp+0FF54],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF40]
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       rcx,[rbp+0FF60]
       mov       [rbp+0FF88],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF12898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF68]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF80]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF78]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF78],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,25E46123298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF68]
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
       mov       rdx,7FFEBCF12970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF68]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF68]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF78]
       mov       ecx,edx
       mov       eax,[rbp+0FF88]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF80]
       mov       [rbp+0FF30],rcx
       mov       [rbp+0FF38],edx
       lea       rdx,[rbp+0FF30]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF70]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       [rbp+0FF88],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFEBCD780E8]
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
       lea       rcx,[rbp+0FF90]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF127C0
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
       mov       rdx,7FFEBCF12A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FF90]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0D0
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
       lea       rbp,[rbp+100]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFEBCF12A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FF90]
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
; Total bytes of code 1025
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rdx,278B6B33020
       mov       rdx,[rdx]
       mov       [rbp+0FFB8],rdx
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFEBCF32220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       lea       r8,[rbp+0FFC0]
       lea       r9,[rbp+0FFB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M01_L03
       mov       rax,278B6B33020
       mov       rax,[rax]
       add       rsp,0D0
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
       lea       rdx,[rbp+0FF90]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFA8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF40],xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       mov       [rbp+0FF60],rcx
       mov       [rbp+0FF40],rcx
       mov       rcx,278B6B32EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFEBCD980E0]
       lea       rcx,[rbp+0FF40]
       mov       [rbp+0FF48],rax
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
       mov       [rbp+0FF50],ecx
       mov       byte ptr [rbp+0FF54],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF40]
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       rcx,[rbp+0FF60]
       mov       [rbp+0FF88],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF32898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF68]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF80]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF78]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF78],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,278B6B33298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF68]
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
       mov       rdx,7FFEBCF32970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF68]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF68]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF78]
       mov       ecx,edx
       mov       eax,[rbp+0FF88]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF80]
       mov       [rbp+0FF30],rcx
       mov       [rbp+0FF38],edx
       lea       rdx,[rbp+0FF30]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF70]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       [rbp+0FF88],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFEBCD980E8]
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
       lea       rcx,[rbp+0FF90]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF327C0
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
       mov       rdx,7FFEBCF32A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FF90]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0D0
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
       lea       rbp,[rbp+100]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFEBCF32A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FF90]
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
; Total bytes of code 1025
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rdx,1F48CC73020
       mov       rdx,[rdx]
       mov       [rbp+0FFB8],rdx
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFEBCF12220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       lea       r8,[rbp+0FFC0]
       lea       r9,[rbp+0FFB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M01_L03
       mov       rax,1F48CC73020
       mov       rax,[rax]
       add       rsp,0D0
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
       lea       rdx,[rbp+0FF90]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFA8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF40],xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       mov       [rbp+0FF60],rcx
       mov       [rbp+0FF40],rcx
       mov       rcx,1F48CC72EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFEBCD780E0]
       lea       rcx,[rbp+0FF40]
       mov       [rbp+0FF48],rax
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
       mov       [rbp+0FF50],ecx
       mov       byte ptr [rbp+0FF54],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF40]
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       rcx,[rbp+0FF60]
       mov       [rbp+0FF88],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF12898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF68]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF80]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF78]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF78],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,1F48CC73298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF68]
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
       mov       rdx,7FFEBCF12970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF68]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF68]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF78]
       mov       ecx,edx
       mov       eax,[rbp+0FF88]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF80]
       mov       [rbp+0FF30],rcx
       mov       [rbp+0FF38],edx
       lea       rdx,[rbp+0FF30]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF70]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       [rbp+0FF88],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFEBCD780E8]
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
       lea       rcx,[rbp+0FF90]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF127C0
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
       mov       rdx,7FFEBCF12A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FF90]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0D0
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
       lea       rbp,[rbp+100]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFEBCF12A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FF90]
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
; Total bytes of code 1025
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rdx,20E49B03020
       mov       rdx,[rdx]
       mov       [rbp+0FFB8],rdx
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFEBCEF2220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       lea       r8,[rbp+0FFC0]
       lea       r9,[rbp+0FFB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M01_L03
       mov       rax,20E49B03020
       mov       rax,[rax]
       add       rsp,0D0
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
       lea       rdx,[rbp+0FF90]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFA8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF40],xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       mov       [rbp+0FF60],rcx
       mov       [rbp+0FF40],rcx
       mov       rcx,20E49B02EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFEBCD580E0]
       lea       rcx,[rbp+0FF40]
       mov       [rbp+0FF48],rax
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
       mov       [rbp+0FF50],ecx
       mov       byte ptr [rbp+0FF54],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF40]
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       rcx,[rbp+0FF60]
       mov       [rbp+0FF88],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCEF2898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF68]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF80]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF78]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF78],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,20E49B03298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF68]
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
       mov       rdx,7FFEBCEF2970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF68]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF68]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF78]
       mov       ecx,edx
       mov       eax,[rbp+0FF88]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF80]
       mov       [rbp+0FF30],rcx
       mov       [rbp+0FF38],edx
       lea       rdx,[rbp+0FF30]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF70]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       [rbp+0FF88],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFEBCD580E8]
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
       lea       rcx,[rbp+0FF90]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCEF27C0
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
       mov       rdx,7FFEBCEF2A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FF90]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0D0
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
       lea       rbp,[rbp+100]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFEBCEF2A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FF90]
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
; Total bytes of code 1025
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rdx,1B35CAB1028
       mov       rdx,[rdx]
       mov       [rbp+0FFB8],rdx
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFEBCF22220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       lea       r8,[rbp+0FFC0]
       lea       r9,[rbp+0FFB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M01_L03
       mov       rax,1B35CAB1028
       mov       rax,[rax]
       add       rsp,0D0
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
       lea       rdx,[rbp+0FF90]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFA8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF40],xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       mov       [rbp+0FF60],rcx
       mov       [rbp+0FF40],rcx
       mov       rcx,1B32CAB2EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFEBCD880E0]
       lea       rcx,[rbp+0FF40]
       mov       [rbp+0FF48],rax
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
       mov       [rbp+0FF50],ecx
       mov       byte ptr [rbp+0FF54],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF40]
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       rcx,[rbp+0FF60]
       mov       [rbp+0FF88],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF22898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF68]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF80]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF78]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF78],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,1B35CAB12A0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF68]
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
       mov       rdx,7FFEBCF22970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF68]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF68]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF78]
       mov       ecx,edx
       mov       eax,[rbp+0FF88]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF80]
       mov       [rbp+0FF30],rcx
       mov       [rbp+0FF38],edx
       lea       rdx,[rbp+0FF30]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF70]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       [rbp+0FF88],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFEBCD880E8]
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
       lea       rcx,[rbp+0FF90]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF227C0
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
       mov       rdx,7FFEBCF22A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FF90]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0D0
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
       lea       rbp,[rbp+100]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFEBCF22A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FF90]
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
; Total bytes of code 1025
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rdx,15A92203020
       mov       rdx,[rdx]
       mov       [rbp+0FFB8],rdx
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFEBCF32220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       lea       r8,[rbp+0FFC0]
       lea       r9,[rbp+0FFB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M01_L03
       mov       rax,15A92203020
       mov       rax,[rax]
       add       rsp,0D0
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
       lea       rdx,[rbp+0FF90]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFA8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF40],xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       mov       [rbp+0FF60],rcx
       mov       [rbp+0FF40],rcx
       mov       rcx,15A92202EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFEBCD980E0]
       lea       rcx,[rbp+0FF40]
       mov       [rbp+0FF48],rax
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
       mov       [rbp+0FF50],ecx
       mov       byte ptr [rbp+0FF54],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF40]
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       rcx,[rbp+0FF60]
       mov       [rbp+0FF88],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF32898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF68]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF80]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF78]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF78],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,15A92203298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF68]
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
       mov       rdx,7FFEBCF32970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF68]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF68]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF78]
       mov       ecx,edx
       mov       eax,[rbp+0FF88]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF80]
       mov       [rbp+0FF30],rcx
       mov       [rbp+0FF38],edx
       lea       rdx,[rbp+0FF30]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF70]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       [rbp+0FF88],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFEBCD980E8]
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
       lea       rcx,[rbp+0FF90]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCF327C0
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
       mov       rdx,7FFEBCF32A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FF90]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0D0
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
       lea       rbp,[rbp+100]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFEBCF32A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FF90]
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
; Total bytes of code 1025
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
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
; DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       [rbp+0FFC8],rcx
       mov       [rbp+10],rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       rdx,18479FF3020
       mov       rdx,[rdx]
       mov       [rbp+0FFB8],rdx
       mov       rbx,[rcx+10]
       cmp       qword ptr [rbx+18],0
       je        short M01_L01
       mov       rax,[rbx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFEBCFAB0C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L02:
       lea       r8,[rbp+0FFC0]
       lea       r9,[rbp+0FFB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef, System.String ByRef)
       test      eax,eax
       jne       short M01_L03
       mov       rax,18479FF3020
       mov       rax,[rax]
       add       rsp,0D0
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
       lea       rdx,[rbp+0FF90]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       near ptr M01_L14
M01_L04:
       lea       rcx,[rbp+0FFA8]
       mov       rdi,[rcx]
       mov       r15,[rcx+8]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF40],xmm0
       vmovdqu   xmmword ptr [rbp+0FF50],xmm0
       mov       [rbp+0FF60],rcx
       mov       [rbp+0FF40],rcx
       mov       rcx,18479FF2EA8
       mov       r12,[rcx]
       mov       rcx,r12
       mov       edx,100
       call      qword ptr [7FFEBCF280E0]
       lea       rcx,[rbp+0FF40]
       mov       [rbp+0FF48],rax
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
       mov       [rbp+0FF50],ecx
       mov       byte ptr [rbp+0FF54],0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF40]
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp+0FF50]
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       rcx,[rbp+0FF60]
       mov       [rbp+0FF88],rcx
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCFAB740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L08:
       lea       rcx,[rbp+0FF68]
       mov       r8,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rdx,[rbp+0FF80]
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       eax,[rbp+0FF78]
       cmp       eax,edx
       jae       short M01_L09
       movsxd    rdx,eax
       mov       word ptr [rcx+rdx*2],3A
       inc       eax
       mov       [rbp+0FF78],eax
       jmp       short M01_L10
M01_L09:
       mov       rdx,18479FF3298
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF68]
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
       mov       rdx,7FFEBCFAB818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L12:
       lea       rcx,[rbp+0FF68]
       mov       r8,r15
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       movzx     edx,si
       lea       rcx,[rbp+0FF68]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,[rbp+0FF78]
       mov       ecx,edx
       mov       eax,[rbp+0FF88]
       cmp       rcx,rax
       ja        near ptr M01_L16
       mov       rcx,[rbp+0FF80]
       mov       [rbp+0FF30],rcx
       mov       [rbp+0FF38],edx
       lea       rdx,[rbp+0FF30]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+0FF70]
       xor       ecx,ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0FF68],xmm0
       vmovdqu   xmmword ptr [rbp+0FF78],xmm0
       mov       [rbp+0FF88],rcx
       test      rdx,rdx
       je        short M01_L13
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FFEBCF280E8]
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
       lea       rcx,[rbp+0FF90]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L04
       jmp       short M01_L18
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rcx,[rbp+10]
       mov       rdx,7FFEBCFAB668
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
       mov       rdx,7FFEBCFAB910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L20:
       lea       rcx,[rbp+0FF90]
       call      rax
       mov       r8d,[r14+1C]
       add       r8d,[r14+18]
       sub       r8d,1
       jo        short M01_L21
       mov       rcx,r14
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       nop
       add       rsp,0D0
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
       lea       rbp,[rbp+100]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+10],40
       jle       short M01_L22
       cmp       qword ptr [rsi+40],0
       je        short M01_L22
       mov       rax,[rsi+40]
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FFEBCFAB910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L23:
       lea       rcx,[rbp+0FF90]
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
; Total bytes of code 1025
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+18]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,1FBDD213020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1FBDD2159D0
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,1FBDD213020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,1FBDD217688
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,1FBDD215B48
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,1FBDD213268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M02_L03
       mov       r11,[r15+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCFE3E88
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
       mov       rdx,7FFEBCFE3F40
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
       mov       rdx,7FFEBCFE3F28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+18]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,284DC2C3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,284BC2C15C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,284DC2C3020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,284DC2CA2F0
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,284BC2C1740
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,284DC2C3268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M02_L03
       mov       r11,[r15+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF53B80
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
       mov       rdx,7FFEBCF53C38
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
       mov       rdx,7FFEBCF53C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+18]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,2794D123020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2794D131E00
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,2794D123020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,2796D121A50
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,2794D131F78
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,2794D123268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M02_L03
       mov       r11,[r15+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCFE3EA0
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
       mov       rdx,7FFEBCFE3F58
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
       mov       rdx,7FFEBCFE3F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+18]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,212C4D23020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,212C4D259D0
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,212C4D23020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,212C4D27688
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,212C4D25B48
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,212C4D23268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M02_L03
       mov       r11,[r15+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCFE3EA0
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
       mov       rdx,7FFEBCFE3F58
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
       mov       rdx,7FFEBCFE3F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+18]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,20BCC373020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,20BCC3759D0
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,20BCC373020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,20BCC377688
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,20BCC375B48
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,20BCC373268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M02_L03
       mov       r11,[r15+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF73B80
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
       mov       rdx,7FFEBCF73C38
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
       mov       rdx,7FFEBCF73C20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+18]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,1C35F943020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1C35F9459D0
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,1C35F943020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,1C38F94DE80
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,1C35F945B48
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,1C35F943268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M02_L03
       mov       r11,[r15+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF73BB0
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
       mov       rdx,7FFEBCF73C68
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
       mov       rdx,7FFEBCF73C50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+18]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,27AEAF71028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,27ACAF735C0
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,27AEAF71028
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,27AEAF812A8
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,27ACAF73738
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,27AEAF71270
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M02_L03
       mov       r11,[r15+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF63B98
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
       mov       rdx,7FFEBCF63C50
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
       mov       rdx,7FFEBCF63C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       r9,[rsi+18]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert(System.Collections.Generic.IDictionary`2<!!0,!!1>, !!0, !!1)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
; Total bytes of code 89
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
       mov       rax,1C9A0AF3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1C980AF15C8
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
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,1C9A0AF3020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,1C9A0B02288
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,1C980AF1740
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,1C9A0AF3268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M02_L03
       mov       r11,[r15+30]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCFF1B98
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
       mov       rdx,7FFEBCFF1C50
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
       mov       rdx,7FFEBCFF1C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
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
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,1FA50483020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1FA504859D0
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
       mov       rdx,7FFEBCF938B0
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
       mov       rdx,7FFEBCF93D78
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
       mov       rdx,7FFEBCF93AA0
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
       mov       rdx,7FFEBCF93D48
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
       mov       rdx,7FFEBCF93D60
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
       mov       rdx,7FFEBCF93BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC9A0630
       call      qword ptr [7FFEBCFB0630]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF93BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFEBC9A0638
       call      qword ptr [7FFEBCFB0638]
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
       mov       r11,7FFEBC9A0640
       call      qword ptr [7FFEBCFB0640]
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
       mov       r11,7FFEBC9A0640
       call      qword ptr [7FFEBCFB0640]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,1FA50483020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,1FA50486670
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,1FA50485B48
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,1FA50483268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M03_L03
       mov       r11,[r15+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF944C8
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
       mov       rdx,7FFEBCF94580
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
       mov       rdx,7FFEBCF94568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
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
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,23359B33020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,23359B359D0
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
       mov       rdx,7FFEBCF638B0
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
       mov       rdx,7FFEBCF63D78
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
       mov       rdx,7FFEBCF63AA0
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
       mov       rdx,7FFEBCF63D48
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
       mov       rdx,7FFEBCF63D60
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
       mov       rdx,7FFEBCF63BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC970630
       call      qword ptr [7FFEBCF80630]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF80638]
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
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF80640]
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
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF80640]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,23359B33020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,23369B31A50
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,23359B35B48
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,23359B33268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M03_L03
       mov       r11,[r15+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF644C8
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
       mov       rdx,7FFEBCF64580
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
       mov       rdx,7FFEBCF64568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
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
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,2D5B7AC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2D5B7AD1E00
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
       mov       rdx,7FFEBCF838E0
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
       mov       rdx,7FFEBCF83DA8
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
       mov       rdx,7FFEBCF83AD0
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
       mov       rdx,7FFEBCF83D78
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
       mov       rdx,7FFEBCF83D90
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
       mov       rdx,7FFEBCF83C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC990630
       call      qword ptr [7FFEBCFA0630]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF83C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCFA0638]
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
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCFA0640]
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
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCFA0640]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,2D5B7AC3020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,2D5C7AC1A50
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,2D5B7AD1F78
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,2D5B7AC3268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M03_L03
       mov       r11,[r15+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF844F8
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
       mov       rdx,7FFEBCF845B0
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
       mov       rdx,7FFEBCF84598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
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
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,2D277F13020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2D277F159D0
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
       mov       rdx,7FFEBCF638E0
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
       mov       rdx,7FFEBCF63DA8
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
       mov       rdx,7FFEBCF63AD0
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
       mov       rdx,7FFEBCF63D78
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
       mov       rdx,7FFEBCF63D90
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
       mov       rdx,7FFEBCF63C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC970630
       call      qword ptr [7FFEBCF80630]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF80638]
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
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF80640]
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
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF80640]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,2D277F13020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,2D297F12A68
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,2D277F15B48
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,2D277F13268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M03_L03
       mov       r11,[r15+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF644F8
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
       mov       rdx,7FFEBCF645B0
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
       mov       rdx,7FFEBCF64598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
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
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,1B87F303020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1B85F3015C8
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
       mov       rdx,7FFEBCF638B0
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
       mov       rdx,7FFEBCF63D78
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
       mov       rdx,7FFEBCF63AA0
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
       mov       rdx,7FFEBCF63D48
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
       mov       rdx,7FFEBCF63D60
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
       mov       rdx,7FFEBCF63BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC970630
       call      qword ptr [7FFEBCF80630]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF63BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFEBC970638
       call      qword ptr [7FFEBCF80638]
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
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF80640]
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
       mov       r11,7FFEBC970640
       call      qword ptr [7FFEBCF80640]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,1B87F303020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,1B88F301A50
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,1B85F301740
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,1B87F303268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M03_L03
       mov       r11,[r15+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF644C8
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
       mov       rdx,7FFEBCF64580
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
       mov       rdx,7FFEBCF64568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
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
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,1B6E6BF3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1B6E6BF59D0
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
       mov       rdx,7FFEBCF738E0
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
       mov       rdx,7FFEBCF73DA8
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
       mov       rdx,7FFEBCF73AD0
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
       mov       rdx,7FFEBCF73D78
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
       mov       rdx,7FFEBCF73D90
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
       mov       rdx,7FFEBCF73C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC980630
       call      qword ptr [7FFEBCF90630]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF73C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCF90638]
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
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF90640]
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
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF90640]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,1B6E6BF3020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,1B6E6BF7688
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,1B6E6BF5B48
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,1B6E6BF3268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M03_L03
       mov       r11,[r15+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF744F8
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
       mov       rdx,7FFEBCF745B0
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
       mov       rdx,7FFEBCF74598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
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
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,1CEA0033020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,1CE700315C8
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
       mov       rdx,7FFEBCF738C8
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
       mov       rdx,7FFEBCF73D90
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
       mov       rdx,7FFEBCF73AB8
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
       mov       rdx,7FFEBCF73D60
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
       mov       rdx,7FFEBCF73D78
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
       mov       rdx,7FFEBCF73BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC980630
       call      qword ptr [7FFEBCF90630]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCF73C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFEBC980638
       call      qword ptr [7FFEBCF90638]
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
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF90640]
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
       mov       r11,7FFEBC980640
       call      qword ptr [7FFEBCF90640]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,1CEA0033020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,1CE70032268
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,1CE70031740
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,1CEA0033268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M03_L03
       mov       r11,[r15+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBCF744E0
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
       mov       rdx,7FFEBCF74598
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
       mov       rdx,7FFEBCF74580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
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
       mov       rdx,[rsi+0F0]
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
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 146
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
       mov       rax,2306DC43020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rdi,rdx
       mov       rax,2306DC51E00
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
       mov       rdx,7FFEBD0118C8
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
       mov       rdx,7FFEBD011D90
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
       mov       rdx,7FFEBD011AB8
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
       mov       rdx,7FFEBD011D60
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
       mov       rdx,7FFEBD011D78
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
       mov       rdx,7FFEBD011BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp+0FFB8],rdi
       mov       rcx,rdi
       mov       r11,7FFEBC990630
       call      qword ptr [7FFEBCF40630]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBD011C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp+0FFC0]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FFEBC990638
       call      qword ptr [7FFEBCF40638]
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
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF40640]
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
       mov       r11,7FFEBC990640
       call      qword ptr [7FFEBCF40640]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rax,2306DC43020
       mov       r14,[rax]
       mov       [rsp+58],r14
       mov       r15,[rbx+10]
       mov       rax,2308DC42A68
       mov       rax,[rax]
       mov       [rsp+50],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+48],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       lea       r8,[rsp+48]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+58],r14
       mov       rax,2306DC51F78
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+58],r14
       mov       rax,2306DC43268
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbp,rbp
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       cmp       qword ptr [r15+30],0
       je        short M03_L03
       mov       r11,[r15+30]
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,7FFEBD0124E0
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
       mov       rdx,7FFEBD012598
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
       mov       rdx,7FFEBD012580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 485
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

