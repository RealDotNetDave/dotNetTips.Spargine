## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rcx,[rbp+10]
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbp
       mov       rdx,7FF9DBCAFAF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FF9DBCAFB90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L04:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,22B
       mov       rdx,7FF9DB9D19D8
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
M01_L06:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9D19D8
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
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9D19D8
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
; Total bytes of code 435
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED1DB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       xor       eax,eax
       test      rbx,rbx
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ECECD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1ADA0010528
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9ECAC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1ADA0002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L17
M01_L02:
       mov       rax,1ADA0002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ECECD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1ADA0010D28
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECAC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1ADA0002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1ADA0002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECA81C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ECECD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECECBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECECD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECECD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCCD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECA83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECECD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCCD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ECECD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1ADA0011018
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECAC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1ADA0002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1ADA0002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECA81C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L24
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ECECD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECECBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECECD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECECD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCCD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECA83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECECD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCCD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF9ED1BED68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L12
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbp
       mov       rdx,7FF9ED1BEE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L14:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9ECECD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECECBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECECD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECECD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCCD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECA83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECECD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCCD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rcx,[rbp+10]
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbp
       mov       rdx,7FF9DBC6FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FF9DBC6FF88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L04:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       ecx,4D
       mov       rdx,7FF9DB9A19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,22B
       mov       rdx,7FF9DB9A19D8
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
M01_L06:
       mov       ecx,4D
       mov       rdx,7FF9DB9A19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9A19D8
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
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9A19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9A19D8
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
; Total bytes of code 435
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED1FB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       xor       eax,eax
       test      rbx,rbx
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,244DCC00068
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,244E0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L17
M01_L02:
       mov       rax,244E0C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,244DEC00050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,244E0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,244E0C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECAB1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,244DEC00340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,244E0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,244E0C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECAB1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L24
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF9ED200EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L12
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbp
       mov       rdx,7FF9ED200F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L14:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rcx,[rbp+10]
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbp
       mov       rdx,7FF9DBC9FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FF9DBC9FF88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L04:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,22B
       mov       rdx,7FF9DB9D19D8
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
M01_L06:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9D19D8
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
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9D19D8
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
; Total bytes of code 435
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5DD438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       xor       eax,eax
       test      rbx,rbx
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED2DD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1B3BF412520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9ECED99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1B3BF402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECED99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L17
M01_L02:
       mov       rax,1B3BF402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED2DD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1B3CB400050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECED99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1B3BF402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECED99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1B3BF402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE91C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED2DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1318D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1318D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED2DD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1B3CB400340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECED99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1B3BF402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECED99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1B3BF402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE91C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L24
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED2DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1318D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1318D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF9ED5E0E78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L12
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbp
       mov       rdx,7FF9ED5E0F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L14:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9ED2DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1318D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1318D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rcx,[rbp+10]
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbp
       mov       rdx,7FF9DBC6FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FF9DBC6FF88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L04:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       ecx,4D
       mov       rdx,7FF9DB9A19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,22B
       mov       rdx,7FF9DB9A19D8
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
M01_L06:
       mov       ecx,4D
       mov       rdx,7FF9DB9A19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9A19D8
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
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9A19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9A19D8
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
; Total bytes of code 435
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5AB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       xor       eax,eax
       test      rbx,rbx
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED29D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1B2A5812520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1B2A5802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L17
M01_L02:
       mov       rax,1B2A5802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED29D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1B2B3800050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1B2A5802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1B2A5802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE51C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED29D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1B2B3800340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1B2A5802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1B2A5802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE51C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L24
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF9ED58F760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L12
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbp
       mov       rdx,7FF9ED58F800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L14:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rcx,[rbp+10]
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbp
       mov       rdx,7FF9DBC7FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FF9DBC7FF88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L04:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,22B
       mov       rdx,7FF9DB9B19D8
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
M01_L06:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 435
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5CB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       xor       eax,eax
       test      rbx,rbx
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1DE1D412520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1DE1D402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L17
M01_L02:
       mov       rax,1DE1D402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1DE1B400050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1DE1D402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1DE1D402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE71C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1DE1B400340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1DE1D402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1DE1D402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE71C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L24
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF9ED5AF760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L12
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbp
       mov       rdx,7FF9ED5AF800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L14:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rcx,[rbp+10]
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbp
       mov       rdx,7FF9DBC7FB78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FF9DBC7FC18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L04:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,22B
       mov       rdx,7FF9DB9B19D8
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
M01_L06:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 435
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED2FD438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       xor       eax,eax
       test      rbx,rbx
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ECFED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,29E89012520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9ECBE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,29E89002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECBE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L17
M01_L02:
       mov       rax,29E89002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ECFED378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,29E89012D20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECBE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,29E89002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECBE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,29E89002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECBA1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ECFED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECE418D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECE418D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECFEBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECFED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECFED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECDED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECBA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECFED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECDED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ECFED378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,29E89013010
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECBE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,29E89002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECBE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,29E89002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECBA1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L24
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ECFED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECE418D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECE418D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECFEBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECFED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECFED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECDED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECBA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECFED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECDED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF9ED2DFDF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L12
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbp
       mov       rdx,7FF9ED2DFE98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L14:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECDD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECDD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9ECFED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECE418D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECE418D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECFEBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECFED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECFED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECDED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECBA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECFED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECDED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECDD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECDD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECDD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECDD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,r9
       mov       r8,[r8+48]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rcx,[rbp+10]
       test      rbx,rbx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbp
       mov       rdx,7FF9DBC7FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbp
       mov       rdx,7FF9DBC7FF88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L04:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,22B
       mov       rdx,7FF9DB9B19D8
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
M01_L06:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 435
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5DB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       r14,[rbp+10]
       xor       eax,eax
       test      rbx,rbx
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1DEA3C04470
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1DEA3C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L17
M01_L02:
       mov       rax,1DEA3C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1DEABC0E100
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1DEA3C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1DEA3C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE81C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1DEABC0E3F0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1DEA3C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1DEA3C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE81C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L24
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF9ED5BFBD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L12
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbp
       mov       rdx,7FF9ED5BFC70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       mov       [rsp+28],rbx
M01_L14:
       mov       rax,[rsp+28]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,20C728892F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20C728892F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,20C728892F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9DBD08548]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9DBCAFF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9DB520970
       call      qword ptr [7FF9DB520970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9DBCD0018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9DB520970
       call      qword ptr [7FF9DB520970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9DB520978
       call      qword ptr [7FF9DB520978]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9DB520978
       call      qword ptr [7FF9DB520978]
M02_L12:
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2762880C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2762880C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2762880C708
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9ED1EB1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 158
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FF9ECD23918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9ED245E40]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9ED1F03F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9EC860A90
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9ED1F04C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9EC860A90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9EC860A98
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FF9ECCEB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF9ECCEB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9EC860A98
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1FC364855F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FC364855E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1FC364855F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9DBCE8908]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9DBC8FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9DBCB0018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
M02_L12:
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1995D40C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1995D40C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1995D40C708
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9ED1DBA98]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 158
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FF9ECD13918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9ED236460]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9ED1BFEB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9EC850A98
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9ED1BFF90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9EC850A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9EC850AA0
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FF9ECCDB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF9ECCDB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9EC850AA0
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2878DF1B2F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2878DF1B2E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2878DF1B2F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9DBCF84C8]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9DBC9FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9DBCC0018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
M02_L12:
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2950380C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2950380C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2950380C708
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9ED5ABA98]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 158
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FF9ED0E3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9ED606200]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9ED58FE30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9ECC20A98
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9ED58FF08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9ECC20A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9ECC20AA0
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FF9ED0AB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF9ED0AB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9ECC20AA0
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,215372F92F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,215372F92F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,215372F92F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9DBCE8CA8]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9DBC8FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9DBCB0018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
M02_L12:
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1560800C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1560800C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1560800C708
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9ED5CD528]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 158
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FF9ED0F3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9ED626A20]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9ED5AE1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9ECC30A98
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9ED5AE290
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9ECC30A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9ECC30AA0
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FF9ED0BB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF9ED0BB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9ECC30AA0
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2DF7E53D700
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2DF7E53D6F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2DF7E53D700
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9DBCC8828]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9DBC6FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9DB4E0970
       call      qword ptr [7FF9DB4E0970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9DBC90018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9DB4E0970
       call      qword ptr [7FF9DB4E0970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9DB4E0978
       call      qword ptr [7FF9DB4E0978]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9DB4E0978
       call      qword ptr [7FF9DB4E0978]
M02_L12:
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1DC0300C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DC0300C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1DC0300C708
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9ED5DBD98]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 158
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FF9ED113918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9ED636A20]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9ED5E0338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9ECC50A98
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9ED5E0410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9ECC50A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9ECC50AA0
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FF9ED0DB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF9ED0DB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9ECC50AA0
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1FED989D700
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FED989D6F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1FED989D700
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9DBCE87E8]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9DBC8FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9DBCB0018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9DB500970
       call      qword ptr [7FF9DB500970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9DB500978
       call      qword ptr [7FF9DB500978]
M02_L12:
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,200A100C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,200A100C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,200A100C708
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9ED2DB528]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 158
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FF9ECE13918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9ED336A60]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9ED2E0F48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9EC950A98
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9ED2E1020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9EC950A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9EC950AA0
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FF9ECDDB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF9ECDDB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9EC950AA0
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F4806892F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F4806892F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1F4806892F8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9DBCF87E8]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9DBC9FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9DBCC0018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
M02_L12:
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1BE4C40C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1BE4C40C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1BE4C40C708
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       je        short M00_L01
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9ED5EB1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 158
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FF9ED113918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9ED6461E0]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
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
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF9ED5CF7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF9ECC50A38
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9ED5CF8A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FF9ECC50A38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF9ECC50A40
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FF9ED0DB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF9ED0DB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FF9ECC50A40
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L09
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBC9FAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBC9FBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBC9FB88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9C19D8
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
M01_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9C19D8
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
M01_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9C19D8
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
; Total bytes of code 466
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED1FB9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,225E2812FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,225E2802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L19
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L19
M01_L02:
       mov       rax,225E2802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,225E2812D20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,225E2802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,225E2802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECAB1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L23
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,225E2813010
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,225E2802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,225E2802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECAB1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L26
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED1DFE58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED1DFF10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED1DFEF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L09
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FF80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9B19D8
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
M01_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M01_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 466
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED1EB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ECEED378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,1E33C4127E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,1E33C402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L19
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L19
M01_L02:
       mov       rax,1E33C402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ECEED378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1E33C412508
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,1E33C402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1E33C402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECAA1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L23
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ECEED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD418D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD418D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEEBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ECEED378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1E33C4127F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,1E33C402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1E33C402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECAA1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L26
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ECEED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD418D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD418D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEEBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED1F0458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED1F0510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED1F04F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF9ECEED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD418D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD418D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEEBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L09
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FF80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9B19D8
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
M01_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M01_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 466
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5AB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED29D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,206F3400328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,206F1402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L19
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L19
M01_L02:
       mov       rax,206F1402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED29D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,206F3400050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,206F1402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,206F1402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE51C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L23
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED29D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,206F3400340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,206F1402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,206F1402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE51C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L26
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED58F750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED58F808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED58F7F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L09
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBC8FEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBC8FF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBC8FF80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9C19D8
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
M01_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9C19D8
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
M01_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9C19D8
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
; Total bytes of code 466
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5BBCA8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,25A17000328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,25A1B002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L19
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L19
M01_L02:
       mov       rax,25A1B002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,25A17000050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,25A1B002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,25A1B002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE71C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L23
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,25A17000340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,25A1B002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,25A1B002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE71C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L26
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED59FB48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED59FC00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED59FBE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L09
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBC7FF80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9B19D8
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
M01_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M01_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 466
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5BD138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,1BE56000328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,1BE4E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L19
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L19
M01_L02:
       mov       rax,1BE4E002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1BE56000050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,1BE4E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1BE4E002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE61C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L23
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1BE56000340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,1BE4E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1BE4E002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE61C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L26
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED59E168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED59E220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED59E208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L09
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBC8FEE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBC8FF98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBC8FF80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9C19D8
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
M01_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9C19D8
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
M01_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9C19D8
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
; Total bytes of code 466
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5B9138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,20E34400328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,20E36402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L19
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L19
M01_L02:
       mov       rax,20E36402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,20E34400050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,20E36402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,20E36402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE71C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L23
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,20E34400340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,20E36402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,20E36402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE71C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L26
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED5C0398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED5C0450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED5C0438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       rdx,r9
       mov       r8,[rdx+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L09
       cmp       qword ptr [rcx+30],0
       je        short M01_L00
       mov       r11,[rcx+30]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBC9FAD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBC9FB90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBC9FB78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9D19D8
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
M01_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9D19D8
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
M01_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9D19D8
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
; Total bytes of code 466
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       r9,[rsi+30]
       mov       r8,[r9+48]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED59D438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,1534B800328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,15349802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L19
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L19
M01_L02:
       mov       rax,15349802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1534B800050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,15349802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,15349802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE61C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L23
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1534B800340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,15349802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,15349802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE61C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L26
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED58F7C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED58F880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M01_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED58F868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
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
       je        short M01_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9DBCB0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9C19D8
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
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       test      rdi,rdi
       jne       near ptr M00_L01
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,12F17413010
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,12F17402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,12F17402028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9ED1FB4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED2232D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF9ECEFD678]
       int       3
; Total bytes of code 326
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FF9ECAF9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M02_L18
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       r14,[rax]
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FF9ED3073A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9ED1FDCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9ED3073C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF9ECA1B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L09
       mov       rcx,[rdi+18]
       mov       r12,[rcx+10]
       mov       rcx,rbx
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rdx,7FF9ED3073A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L05:
       test      r12,r12
       je        short M02_L06
       cmp       [r12],rax
       je        short M02_L06
       xor       r12d,r12d
M02_L06:
       test      r12,r12
       je        short M02_L09
       mov       rcx,[r12+8]
       mov       rdx,[r15+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L09
       mov       rsi,[rdi+18]
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdx,7FF9ED307648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9ED221048]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FF9ED307648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9ED221018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       r11,[r14+58]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rdx,7FF9ED307668
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF9EC870AA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       rcx,rbx
       mov       r11,[r14+60]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rdx,7FF9ED307688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp-48]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rax,[rbp-48]
       mov       r8,[rbp-40]
       mov       [rbp-58],rax
       mov       [rbp-50],r8
       mov       rcx,rdx
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED211A28]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF9EC870AA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF9EC870AB0
       call      qword ptr [r11]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,80F
       mov       rdx,7FF9ECD01B00
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9ECCFD960]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M02_L19
       mov       rcx,[rbp-60]
       mov       r11,7FF9EC870AB0
       call      qword ptr [r11]
M02_L19:
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
; Total bytes of code 731
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
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
       je        short M01_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9DBCA0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       test      rdi,rdi
       jne       near ptr M00_L01
       call      qword ptr [7FF9ECEED378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1DEB9C00340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,1DEB7C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,1DEB7C02028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9ED1FB4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED2232D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF9ECEED678]
       int       3
; Total bytes of code 326
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FF9ECAE9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M02_L18
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       r14,[rax]
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FF9ED3337F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9ED1FDCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9ED333810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF9ECA0B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L09
       mov       rcx,[rdi+18]
       mov       r12,[rcx+10]
       mov       rcx,rbx
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rdx,7FF9ED3337F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L05:
       test      r12,r12
       je        short M02_L06
       cmp       [r12],rax
       je        short M02_L06
       xor       r12d,r12d
M02_L06:
       test      r12,r12
       je        short M02_L09
       mov       rcx,[r12+8]
       mov       rdx,[r15+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L09
       mov       rsi,[rdi+18]
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdx,7FF9ED333A98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9ED221048]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FF9ED333A98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9ED221018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       r11,[r14+58]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rdx,7FF9ED333AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF9EC860AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       rcx,rbx
       mov       r11,[r14+60]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rdx,7FF9ED333AD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp-48]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rax,[rbp-48]
       mov       r8,[rbp-40]
       mov       [rbp-58],rax
       mov       [rbp-50],r8
       mov       rcx,rdx
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED211CE8]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF9EC860AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF9EC860AB8
       call      qword ptr [r11]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,80F
       mov       rdx,7FF9ECCF1B00
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9ECCED960]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M02_L19
       mov       rcx,[rbp-60]
       mov       r11,7FF9EC860AB8
       call      qword ptr [r11]
M02_L19:
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
; Total bytes of code 731
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
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
       je        short M01_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9DBCA0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       test      rdi,rdi
       jne       near ptr M00_L01
       call      qword ptr [7FF9ED29D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,26C68C13010
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,26C68C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,26C68C02028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9ED59B4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED5C32D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF9ED29D678]
       int       3
; Total bytes of code 326
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FF9ECE99A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M02_L18
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       r14,[rax]
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FF9ED6A5B38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9ED59DCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9ED6A5B50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF9ECDBB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L09
       mov       rcx,[rdi+18]
       mov       r12,[rcx+10]
       mov       rcx,rbx
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rdx,7FF9ED6A5B38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L05:
       test      r12,r12
       je        short M02_L06
       cmp       [r12],rax
       je        short M02_L06
       xor       r12d,r12d
M02_L06:
       test      r12,r12
       je        short M02_L09
       mov       rcx,[r12+8]
       mov       rdx,[r15+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L09
       mov       rsi,[rdi+18]
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdx,7FF9ED6A5DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9ED5C1048]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FF9ED6A5DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9ED5C1018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       r11,[r14+58]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rdx,7FF9ED6A5DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF9ECC10AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       rcx,rbx
       mov       r11,[r14+60]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rdx,7FF9ED6A5E18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp-48]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rax,[rbp-48]
       mov       r8,[rbp-40]
       mov       [rbp-58],rax
       mov       [rbp-50],r8
       mov       rcx,rdx
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED5B1848]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF9ECC10AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF9ECC10AB8
       call      qword ptr [r11]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,80F
       mov       rdx,7FF9ED0A1B00
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9ED09D960]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M02_L19
       mov       rcx,[rbp-60]
       mov       r11,7FF9ECC10AB8
       call      qword ptr [r11]
M02_L19:
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
; Total bytes of code 731
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
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
       je        short M01_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9DBCC0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9D19D8
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
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       test      rdi,rdi
       jne       near ptr M00_L01
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1C6BE000340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,1C6B4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,1C6B4002028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9ED5BD030]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED5E3978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF9ED2BD678]
       int       3
; Total bytes of code 326
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FF9ECEB9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M02_L18
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       r14,[rax]
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FF9ED6F4D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9ED5BF618]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9ED6F4D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF9ECDDB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L09
       mov       rcx,[rdi+18]
       mov       r12,[rcx+10]
       mov       rcx,rbx
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rdx,7FF9ED6F4D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L05:
       test      r12,r12
       je        short M02_L06
       cmp       [r12],rax
       je        short M02_L06
       xor       r12d,r12d
M02_L06:
       test      r12,r12
       je        short M02_L09
       mov       rcx,[r12+8]
       mov       rdx,[r15+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L09
       mov       rsi,[rdi+18]
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdx,7FF9ED6F4FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9ED5E1780]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FF9ED6F4FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9ED5E1750]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       r11,[r14+58]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rdx,7FF9ED6F4FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF9ECC30AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       rcx,rbx
       mov       r11,[r14+60]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rdx,7FF9ED6F4FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp-48]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rax,[rbp-48]
       mov       r8,[rbp-40]
       mov       [rbp-58],rax
       mov       [rbp-50],r8
       mov       rcx,rdx
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED5D1848]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF9ECC30AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF9ECC30AB8
       call      qword ptr [r11]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,80F
       mov       rdx,7FF9ED0C1B00
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9ED0BD960]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M02_L19
       mov       rcx,[rbp-60]
       mov       r11,7FF9ECC30AB8
       call      qword ptr [r11]
M02_L19:
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
; Total bytes of code 731
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
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
       je        short M01_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9DBCA0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       test      rdi,rdi
       jne       near ptr M00_L01
       call      qword ptr [7FF9ED29D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1FCD1400340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,1FCCF402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,1FCCF402028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9ED59B4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED5C32D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF9ED29D678]
       int       3
; Total bytes of code 326
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FF9ECE99A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M02_L18
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       r14,[rax]
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FF9ED6A5E68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9ED59DCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9ED6A5E80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF9ECDBB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L09
       mov       rcx,[rdi+18]
       mov       r12,[rcx+10]
       mov       rcx,rbx
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rdx,7FF9ED6A5E68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L05:
       test      r12,r12
       je        short M02_L06
       cmp       [r12],rax
       je        short M02_L06
       xor       r12d,r12d
M02_L06:
       test      r12,r12
       je        short M02_L09
       mov       rcx,[r12+8]
       mov       rdx,[r15+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L09
       mov       rsi,[rdi+18]
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdx,7FF9ED6A6108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9ED5C1048]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FF9ED6A6108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9ED5C1018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       r11,[r14+58]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rdx,7FF9ED6A6128
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF9ECC10AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       rcx,rbx
       mov       r11,[r14+60]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rdx,7FF9ED6A6148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp-48]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rax,[rbp-48]
       mov       r8,[rbp-40]
       mov       [rbp-58],rax
       mov       [rbp-50],r8
       mov       rcx,rdx
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED5B1848]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF9ECC10AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF9ECC10AB8
       call      qword ptr [r11]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,80F
       mov       rdx,7FF9ED0A1B00
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9ED09D960]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M02_L19
       mov       rcx,[rbp-60]
       mov       r11,7FF9ECC10AB8
       call      qword ptr [r11]
M02_L19:
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
; Total bytes of code 731
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
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
       je        short M01_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9DBCB0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FF9DB9C19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9C19D8
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
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       test      rdi,rdi
       jne       near ptr M00_L01
       call      qword ptr [7FF9ECFED378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1F1AD011018
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECBE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,1F1AD000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECBE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,1F1AD000030
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9ED2FD7B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED3152D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECDD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECDD1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF9ECFED678]
       int       3
; Total bytes of code 326
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FF9ECBE9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M02_L18
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       r14,[rax]
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FF9ED431D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9ED2FFCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9ED431D88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF9ECB0B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L09
       mov       rcx,[rdi+18]
       mov       r12,[rcx+10]
       mov       rcx,rbx
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rdx,7FF9ED431D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L05:
       test      r12,r12
       je        short M02_L06
       cmp       [r12],rax
       je        short M02_L06
       xor       r12d,r12d
M02_L06:
       test      r12,r12
       je        short M02_L09
       mov       rcx,[r12+8]
       mov       rdx,[r15+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L09
       mov       rsi,[rdi+18]
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdx,7FF9ED432010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9ED313048]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FF9ED432010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9ED313018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       r11,[r14+58]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rdx,7FF9ED432030
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF9EC960AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       rcx,rbx
       mov       r11,[r14+60]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rdx,7FF9ED432050
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp-48]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rax,[rbp-48]
       mov       r8,[rbp-40]
       mov       [rbp-58],rax
       mov       [rbp-50],r8
       mov       rcx,rdx
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED302C28]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF9EC960AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF9EC960AB8
       call      qword ptr [r11]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,80F
       mov       rdx,7FF9ECDF1B00
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9ECDED960]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M02_L19
       mov       rcx,[rbp-60]
       mov       r11,7FF9EC960AB8
       call      qword ptr [r11]
M02_L19:
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
; Total bytes of code 731
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
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
       je        short M01_L02
       mov       rdx,[rax+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF9DBCD0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FF9DB9E19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9E19D8
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
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       test      rdi,rdi
       jne       near ptr M00_L01
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,28AA2C00340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,28AA6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,28AA6C02028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9ED5DD7B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED5F52D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF9ED2CD678]
       int       3
; Total bytes of code 326
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FF9ECEC9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-70],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M02_L18
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       r14,[rax]
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FF9ED710D38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9ED5DFCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9ED710D50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF9ECDEB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L09
       mov       rcx,[rdi+18]
       mov       r12,[rcx+10]
       mov       rcx,rbx
       mov       rax,[r14+40]
       test      rax,rax
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rdx,7FF9ED710D38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L05:
       test      r12,r12
       je        short M02_L06
       cmp       [r12],rax
       je        short M02_L06
       xor       r12d,r12d
M02_L06:
       test      r12,r12
       je        short M02_L09
       mov       rcx,[r12+8]
       mov       rdx,[r15+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L09
       mov       rsi,[rdi+18]
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdx,7FF9ED710FD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9ED5F3048]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       rcx,rbx
       mov       rdx,[r14+50]
       test      rdx,rdx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FF9ED710FD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9ED5F3018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       r11,[r14+58]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rdx,7FF9ED710FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF9ECC40AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L17
M02_L14:
       mov       rcx,rbx
       mov       r11,[r14+60]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rdx,7FF9ED711018
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L16:
       lea       rdx,[rbp-48]
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rax,[rbp-48]
       mov       r8,[rbp-40]
       mov       [rbp-58],rax
       mov       [rbp-50],r8
       mov       rcx,rdx
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED5E2C58]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF9ECC40AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF9ECC40AB8
       call      qword ptr [r11]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       ecx,80F
       mov       rdx,7FF9ED0D1B00
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9ED0CD960]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M02_L19
       mov       rcx,[rbp-60]
       mov       r11,7FF9ECC40AB8
       call      qword ptr [r11]
M02_L19:
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
; Total bytes of code 731
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9DBC7FDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9DBC7FFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA02B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9DB4F0980
       call      qword ptr [7FF9DB4F0980]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9DB4F0980
       call      qword ptr [7FF9DB4F0980]
M01_L22:
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L09
       cmp       qword ptr [rcx+30],0
       je        short M02_L00
       mov       r11,[rcx+30]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA0958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9B19D8
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
M02_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M02_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 466
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9ED1FBA38]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED1FB9D8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9ECCFB7E0]
       int       3
; Total bytes of code 146
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9ED1DFAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9ECA1B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9ED1DFF70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9ED1DFC98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9ECA1B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9ED1DFF40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9ED1DFF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9ED1DFDC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9EC870AD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9ED1DFDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9EC870AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9EC870AE0
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9ECCFB780]
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9EC870AE0
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,20AFB012FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,20AFB002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M02_L02
       mov       rcx,r15
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L19
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L19
M02_L02:
       mov       rax,20AFB002028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,20AFB012D20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,20AFB002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,20AFB002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECAB1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L23
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L05
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF9ECEFD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,20AFB013010
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,20AFB002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,20AFB002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECAB1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L26
       mov       eax,1
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED200568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED200620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED200608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF9ECEFD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD518D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEFD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEFD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEFD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L04
M02_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCE1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9DBC7FDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9DBC7FFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA02B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9DB4F0980
       call      qword ptr [7FF9DB4F0980]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9DB4F0980
       call      qword ptr [7FF9DB4F0980]
M01_L22:
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L09
       cmp       qword ptr [rcx+30],0
       je        short M02_L00
       mov       r11,[rcx+30]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA0958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9B19D8
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
M02_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M02_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 466
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9ED1DBD38]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED1DBCD8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9ECCDB7E0]
       int       3
; Total bytes of code 146
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9ED1BFE90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9EC9FB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9ED1E0358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9ED1BFFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9EC9FB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9ED1E0328
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9ED1E0340
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9ED1E01B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9EC850AD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9ED1E01C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9EC850AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9EC850AE0
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9ECCDB780]
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9EC850AE0
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9ECEDD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,21A0CC00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECAD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,21A08C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M02_L02
       mov       rcx,r15
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L19
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L19
M02_L02:
       mov       rax,21A08C02028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF9ECEDD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,21A0CC00050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECAD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,21A08C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,21A08C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECA91C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L23
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L05
       call      qword ptr [7FF9ECEDD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD318D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD318D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEDBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEDD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEDD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECA93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEDD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF9ECEDD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,21A0CC00340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECAD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,21A08C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECAD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,21A08C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECA91C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L26
       mov       eax,1
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FF9ECEDD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD318D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD318D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEDBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEDD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEDD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECA93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEDD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED1E0948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED1E0A00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED1E09E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCC1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCC1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF9ECEDD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ECD318D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ECD318D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ECEDBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ECEDD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECEDD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ECCDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECA93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ECEDD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ECCDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCC1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCC1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L04
M02_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCC1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ECCC1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9DBC9FDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9DBC9FFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC0298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC02B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9DB510980
       call      qword ptr [7FF9DB510980]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9DB510980
       call      qword ptr [7FF9DB510980]
M01_L22:
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L09
       cmp       qword ptr [rcx+30],0
       je        short M02_L00
       mov       r11,[rcx+30]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBCC08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBCC0958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBCC0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9D19D8
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
M02_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9D19D8
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
M02_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9D19D8
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
; Total bytes of code 466
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9ED59D198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED59D138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9ED0AB7E0]
       int       3
; Total bytes of code 146
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9ED58F8E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FD78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FD90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FC00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9ECC20AD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FC18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9ECC20AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9ECC20AE0
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9ED0AB780]
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9ECC20AE0
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,28F69000328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,28F65002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M02_L02
       mov       rcx,r15
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L19
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L19
M02_L02:
       mov       rax,28F65002028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,28F69000050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,28F65002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,28F65002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE61C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L23
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L05
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF9ED2AD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,28F69000340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,28F65002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,28F65002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE61C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L26
       mov       eax,1
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED5B0398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED5B0450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED5B0438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF9ED2AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1018D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L04
M02_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9DBC7FDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9DBC7FFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA02B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9DB4F0980
       call      qword ptr [7FF9DB4F0980]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9DB4F0980
       call      qword ptr [7FF9DB4F0980]
M01_L22:
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L09
       cmp       qword ptr [rcx+30],0
       je        short M02_L00
       mov       r11,[rcx+30]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA0958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9B19D8
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
M02_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M02_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 466
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9ED5AD4C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5AD468]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9ED0BB7E0]
       int       3
; Total bytes of code 146
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9ED5C0620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDDB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9ED5C0AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9ED5C0810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDDB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9ED5C0AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9ED5C0AD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9ED5C0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9ECC30AD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9ED5C0958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9ECC30AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9ECC30AE0
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9ED0BB780]
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9ECC30AE0
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,1BFF2C00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,1BFECC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M02_L02
       mov       rcx,r15
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L19
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L19
M02_L02:
       mov       rax,1BFECC02028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1BFF2C00050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,1BFECC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1BFECC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE71C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L23
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L05
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF9ED2BD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1BFF2C00340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,1BFECC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1BFECC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE71C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L26
       mov       eax,1
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED5C10D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED5C1190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED5C1178
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF9ED2BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1118D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L04
M02_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9DBC9FDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9DBC9FFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC0298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC02B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9DB510970
       call      qword ptr [7FF9DB510970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9DBCC0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9DB510978
       call      qword ptr [7FF9DB510978]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9DB510980
       call      qword ptr [7FF9DB510980]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9DB510980
       call      qword ptr [7FF9DB510980]
M01_L22:
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L09
       cmp       qword ptr [rcx+30],0
       je        short M02_L00
       mov       r11,[rcx+30]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBCC08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBCC0958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBCC0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9D19D8
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
M02_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9D19D8
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
M02_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9D19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9D19D8
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
; Total bytes of code 466
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9ED5DB198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5DB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9ED0CB7E0]
       int       3
; Total bytes of code 146
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BF958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFB48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFDF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFC78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9ECC40AD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFC90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9ECC40AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9ECC40AE0
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9ED0CB780]
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9ECC40AE0
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,24E66C00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,24E68C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M02_L02
       mov       rcx,r15
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L19
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L19
M02_L02:
       mov       rax,24E68C02028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,24E66C00050
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,24E68C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,24E68C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE81C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L23
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L05
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,24E66C00340
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,24E68C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,24E68C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE81C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L26
       mov       eax,1
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED5E0410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED5E04C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED5E04B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L04
M02_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9DBCAFDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9DBCD02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9DBCAFFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9DBCD0298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9DBCD02B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9DBCD0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9DB520970
       call      qword ptr [7FF9DB520970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9DBCD0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9DB520978
       call      qword ptr [7FF9DB520978]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9DB520980
       call      qword ptr [7FF9DB520980]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9DB520980
       call      qword ptr [7FF9DB520980]
M01_L22:
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L09
       cmp       qword ptr [rcx+30],0
       je        short M02_L00
       mov       r11,[rcx+30]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBCD08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBCD0958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBCD0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9E19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9E19D8
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
M02_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9E19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9E19D8
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
M02_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9E19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9E19D8
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
; Total bytes of code 466
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9ED5DB198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5DB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9ED0CB7E0]
       int       3
; Total bytes of code 146
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BF700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFBC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BF8F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFA20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9ECC40AD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9ED5BFA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9ECC40AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9ECC40AE0
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9ED0CB780]
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9ECC40AE0
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,236F5C12FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,236F5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M02_L02
       mov       rcx,r15
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L19
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L19
M02_L02:
       mov       rax,236F5C02028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,236F5C12D20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,236F5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,236F5C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE81C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L23
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L05
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,236F5C13010
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,236F5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,236F5C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE81C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L26
       mov       eax,1
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED5E01C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED5E0278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED5E0260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF9ED2CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED1218D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED2CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED2CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED2CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L04
M02_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9DBC7FDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9DBC7FFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA02B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9DB4F0970
       call      qword ptr [7FF9DB4F0970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9DBCA0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9DB4F0978
       call      qword ptr [7FF9DB4F0978]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9DB4F0980
       call      qword ptr [7FF9DB4F0980]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9DB4F0980
       call      qword ptr [7FF9DB4F0980]
M01_L22:
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,[rbx+10]
       test      rbp,rbp
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L07
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L08
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M02_L09
       cmp       qword ptr [rcx+30],0
       je        short M02_L00
       mov       r11,[rcx+30]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA08A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA0958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L04:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L05
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rbx
       mov       rdx,7FF9DBCA0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L06:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF9DB9B19D8
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
M02_L08:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,223
       mov       rdx,7FF9DB9B19D8
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
M02_L09:
       mov       ecx,4D
       mov       rdx,7FF9DB9B19D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF9DB9B19D8
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
; Total bytes of code 466
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9ED5AB198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9ED5AB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9ED09B7E0]
       int       3
; Total bytes of code 146
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9ED58F6D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDBB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
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
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9ED58F8C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9ECDBB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FB68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FB80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
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
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9ED58F9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9ECC10AD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9ED58FA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9ECC10AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9ECC10AE0
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
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
M01_L19:
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
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9ED09B780]
       int       3
M01_L21:
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
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9ECC10AE0
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       r14,[rbx+10]
       xor       eax,eax
       test      rbp,rbp
       setne     al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9ED29D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,18502412FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,18502402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M02_L02
       mov       rcx,r15
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L19
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L19
M02_L02:
       mov       rax,18502402028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF9ED29D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,18502412D20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,18502402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,18502402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE51C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L23
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L05
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF9ED29D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,18502413010
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,18502402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECE999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,18502402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9ECE51C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L26
       mov       eax,1
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF9ED5B0190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L11:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L14
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L12
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rbx
       mov       rdx,7FF9ED5B0248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [r11]
M02_L14:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L15
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rbx
       mov       rdx,7FF9ED5B0230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L16:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF9ED29D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9ED0F18D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9ED29BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9ED29D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED29D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED29D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED09D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L23:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L04
M02_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

