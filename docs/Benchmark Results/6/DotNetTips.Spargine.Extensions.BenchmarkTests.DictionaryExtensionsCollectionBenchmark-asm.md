## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490A3B98
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
       mov       rdx,7FF9490A3C38
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,21D
       mov       rdx,7FF948DA1900
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DA1900
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DA1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99566B138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99535D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,2603A00A410
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,2603A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2603A002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99535D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,2603A00AC08
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,2603A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2603A002028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F11C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99535D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,2603A00AEE8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,2603A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2603A002028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F11C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF995670BA8
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
       mov       rdx,7FF995670C48
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94908FAE0
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
       mov       rdx,7FF94908FB80
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,21D
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DC1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99565D138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99536D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,21CC6C12520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,21CC6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21CC6C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99536D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,21CC2C00048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,21CC6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,21CC6C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F21C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99536D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,21CC2C00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,21CC6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,21CC6C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F21C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF99564FC28
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
       mov       rdx,7FF99564FCC8
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
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
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
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94909FAF0
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
       mov       rdx,7FF94909FB90
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,21D
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DD1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99565B438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99534D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1C80D012520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1C80D002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C80D002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99534D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1C80D012D18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1C80D002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1C80D002028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99534D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1C80D012FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1C80D002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1C80D002028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF99563FCA8
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
       mov       rdx,7FF99563FD48
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94909FEE8
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
       mov       rdx,7FF94909FF88
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,21D
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DD1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99565BCA8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99535D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1A5C0C12520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1A5C0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A5C0C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99535D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1A5BCC00048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1A5C0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1A5C0C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F11C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99535D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1A5BCC00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1A5C0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1A5C0C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F11C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF995660028
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
       mov       rdx,7FF9956600C8
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94908FEE8
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
       mov       rdx,7FF94908FF88
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,21D
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DC1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99564B138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99534D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1CA7FC12520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1CA7FC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1CA7FC02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99534D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1CA7BC00048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1CA7FC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1CA7FC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99534D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1CA7BC00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1CA7FC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1CA7FC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF9956505A8
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
       mov       rdx,7FF995650648
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94906FEE8
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
       mov       rdx,7FF94906FF88
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,21D
       mov       rdx,7FF948DA1900
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DA1900
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DA1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99486B438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99456D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1F09D810528
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1F09D800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F09D800030
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99456D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1F099800048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1F09D800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1F09D800030
       mov       rdx,[rdx]
       call      qword ptr [7FF994121C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99456D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99456BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99456D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99456D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994123510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99456D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99456D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1F099800328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1F09D800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1F09D800030
       mov       rdx,[rdx]
       call      qword ptr [7FF994121C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99456D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99456BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99456D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99456D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994123510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99456D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF99484F9C0
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
       mov       rdx,7FF99484FA60
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
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF99456D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99456BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99456D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99456D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994123510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99456D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994341C78]
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
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94909FEE8
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
       mov       rdx,7FF94909FF88
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,21D
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DD1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99487B138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99457D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L15
       lea       rcx,[r15+0C]
       mov       rdx,1F7DAC12520
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r15+16]
       mov       rdx,1F7DAC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F7DAC02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99457D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L19
       lea       rcx,[rdi+0C]
       mov       rdx,1F7D8C00048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L20
       lea       rcx,[rdi+12]
       mov       rdx,1F7DAC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1F7DAC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994131C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99457D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99457BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99457D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99457D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994133510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99457D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99457D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L22
       lea       rcx,[rsi+0C]
       mov       rdx,1F7D8C00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,1F7DAC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1F7DAC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994131C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99457D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99457BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99457D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99457D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994133510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99457D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,7FF99485F688
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
       mov       rdx,7FF99485F728
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
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF99457D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99457BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99457D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99457D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994133510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99457D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
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
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1567
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2A55941D700
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A55941D6F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2A55941D700
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
       vdivsd    xmm0,xmm0,[7FF9490D8828]
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
       mov       rdx,7FF94907FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF948900970
       call      qword ptr [7FF948900970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9490A0018
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
       mov       r11,7FF948900970
       call      qword ptr [7FF948900970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF948900978
       call      qword ptr [7FF948900978]
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
       mov       r11,7FF948900978
       call      qword ptr [7FF948900978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1E6B1408300
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E6B14082F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1E6B1408300
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
       call      qword ptr [7FF99566DD98]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       call      qword ptr [7FF9951A3918]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF9956C6200]
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
       mov       rdx,7FF9956804F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF994CE0AA8
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
       mov       rdx,7FF9956805D0
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
       mov       r11,7FF994CE0AA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF994CE0AB0
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
       call      qword ptr [7FF99516B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF99516B780]
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
       mov       r11,7FF994CE0AB0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1B7DD1992F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B7DD1992F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1B7DD1992F8
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
       vdivsd    xmm0,xmm0,[7FF9490E8A48]
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
       mov       rdx,7FF94908FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF948910970
       call      qword ptr [7FF948910970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9490B0018
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
       mov       r11,7FF948910970
       call      qword ptr [7FF948910970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF948910978
       call      qword ptr [7FF948910978]
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
       mov       r11,7FF948910978
       call      qword ptr [7FF948910978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2279E80C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2279E80C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2279E80C708
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
       call      qword ptr [7FF99564B1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       call      qword ptr [7FF995183918]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF9956A60C0]
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
       mov       rdx,7FF995650AD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF994CC0A98
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
       mov       rdx,7FF995650BA8
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
       mov       r11,7FF994CC0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF994CC0AA0
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
       call      qword ptr [7FF99514B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF99514B780]
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
       mov       r11,7FF994CC0AA0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,16D67A2D700
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,16D67A2D6F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,16D67A2D700
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
       vdivsd    xmm0,xmm0,[7FF9490E7948]
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
       mov       rdx,7FF94908FB28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF948910970
       call      qword ptr [7FF948910970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF94908FC00
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
       mov       r11,7FF948910970
       call      qword ptr [7FF948910970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF948910978
       call      qword ptr [7FF948910978]
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
       mov       r11,7FF948910978
       call      qword ptr [7FF948910978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,246EAC0C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,246EAC0C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,246EAC0C708
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
       call      qword ptr [7FF99565D1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       call      qword ptr [7FF995183918]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF9956B6020]
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
       mov       rdx,7FF99563F3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF994CC0A98
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
       mov       rdx,7FF99563F498
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
       mov       r11,7FF994CC0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF994CC0AA0
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
       call      qword ptr [7FF99514B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF99514B780]
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
       mov       r11,7FF994CC0AA0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F27A7192F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F27A7192F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1F27A7192F8
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
       vdivsd    xmm0,xmm0,[7FF949108DE8]
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
       mov       rdx,7FF9490AFF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF948930970
       call      qword ptr [7FF948930970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9490D0018
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
       mov       r11,7FF948930970
       call      qword ptr [7FF948930970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF948930978
       call      qword ptr [7FF948930978]
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
       mov       r11,7FF948930978
       call      qword ptr [7FF948930978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1BD54408300
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1BD544082F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1BD54408300
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
       call      qword ptr [7FF99566B1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       call      qword ptr [7FF9951A3918]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF9956C6700]
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
       mov       rdx,7FF995670670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF994CE0A98
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
       mov       rdx,7FF995670748
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
       mov       r11,7FF994CE0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF994CE0AA0
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
       call      qword ptr [7FF99516B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF99516B780]
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
       mov       r11,7FF994CE0AA0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1A00375D700
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A00375D6F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1A00375D700
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
       vdivsd    xmm0,xmm0,[7FF9490F8DC8]
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
       mov       rdx,7FF94909FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF948920970
       call      qword ptr [7FF948920970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9490C0018
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
       mov       r11,7FF948920970
       call      qword ptr [7FF948920970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF948920978
       call      qword ptr [7FF948920978]
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
       mov       r11,7FF948920978
       call      qword ptr [7FF948920978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1EE6040C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1EE6040C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1EE6040C708
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
       call      qword ptr [7FF99564BA98]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       call      qword ptr [7FF995183918]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF9956A68E0]
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
       mov       rdx,7FF99562FFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF994CC0A98
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
       mov       rdx,7FF9956500C0
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
       mov       r11,7FF994CC0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF994CC0AA0
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
       call      qword ptr [7FF99514B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF99514B780]
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
       mov       r11,7FF994CC0AA0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1B8B5EA92F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B8B5EA92F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1B8B5EA92F8
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
       vdivsd    xmm0,xmm0,[7FF9490D8FC8]
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
       mov       rdx,7FF94907FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF948900970
       call      qword ptr [7FF948900970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF9490A0018
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
       mov       r11,7FF948900970
       call      qword ptr [7FF948900970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF948900978
       call      qword ptr [7FF948900978]
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
       mov       r11,7FF948900978
       call      qword ptr [7FF948900978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,13DE480C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,13DE480C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,13DE480C708
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
       call      qword ptr [7FF99485B528]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       call      qword ptr [7FF994393918]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF9948B68A0]
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
       mov       rdx,7FF994860380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF993ED0A98
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
       mov       rdx,7FF994860458
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
       mov       r11,7FF993ED0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF993ED0AA0
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
       call      qword ptr [7FF99435B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF99435B780]
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
       mov       r11,7FF993ED0AA0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1682DED92F8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1682DED92F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1682DED92F8
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
       vdivsd    xmm0,xmm0,[7FF9490E7C48]
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
       mov       rdx,7FF94908FB28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF948910970
       call      qword ptr [7FF948910970]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FF94908FC00
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
       mov       r11,7FF948910970
       call      qword ptr [7FF948910970]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF948910978
       call      qword ptr [7FF948910978]
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
       mov       r11,7FF948910978
       call      qword ptr [7FF948910978]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C71B40C708
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C71B40C700
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1C71B40C708
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
       call      qword ptr [7FF99484D1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
       call      qword ptr [7FF994393918]; System.DateTime.get_UtcNow()
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
       vdivsd    xmm0,xmm0,[7FF9948B6900]
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
       mov       rdx,7FF994860088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FF993ED0A98
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
       mov       rdx,7FF994860160
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
       mov       r11,7FF993ED0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FF993ED0AA0
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
       call      qword ptr [7FF99435B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FF99435B780]
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
       mov       r11,7FF993ED0AA0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94908FEE0
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
       mov       rdx,7FF94908FF98
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
       mov       rdx,7FF94908FF80
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DC1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99564B438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99533D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,1C589400310
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,1C587402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C587402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99533D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1C589400048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,1C587402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1C587402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994EF1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99533D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99533BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99533D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99533D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994EF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99533D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99533D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1C589400328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,1C587402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1C587402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994EF1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99533D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99533BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99533D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99533D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994EF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99533D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF99562FFA8
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
       mov       rdx,7FF99562FFD8
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
       mov       rdx,7FF99562FFC0
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
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF99533D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99533BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99533D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99533D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994EF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99533D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995111C78]
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
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94909FEE0
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
       mov       rdx,7FF94909FF98
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
       mov       rdx,7FF94909FF80
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DD1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99564D138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99534D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,1F3B6C12FE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,1F3B6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F3B6C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99534D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1F3B6C12D18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,1F3B6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1F3B6C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99534D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1F3B6C12FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,1F3B6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1F3B6C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9956504D8
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
       mov       rdx,7FF995650590
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
       mov       rdx,7FF995650578
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94908FAE8
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
       mov       rdx,7FF94908FBA0
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
       mov       rdx,7FF94908FB88
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DC1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99565B9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99535D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,2024E400310
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,2024A402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2024A402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99535D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,2024E400048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,2024A402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2024A402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F11C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99535D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,2024E400328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,2024A402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2024A402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F11C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF995660238
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
       mov       rdx,7FF9956602F0
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
       mov       rdx,7FF9956602D8
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490AFEE0
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
       mov       rdx,7FF9490AFF98
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
       mov       rdx,7FF9490AFF80
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DE1900
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DE1900
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DE1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99563B438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99533D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,1ED29C00310
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,1ED2DC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1ED2DC02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99533D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1ED29C00048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,1ED2DC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1ED2DC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994EF1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99533D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99533BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99533D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99533D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994EF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99533D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99533D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1ED29C00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,1ED2DC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1ED2DC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994EF1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99533D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99533BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99533D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99533D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994EF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99533D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9956404C8
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
       mov       rdx,7FF995640580
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
       mov       rdx,7FF995640568
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
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF99533D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF995191640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99533BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99533D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99533D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994EF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99533D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99513D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995111C78]
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
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995111C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94907FEE0
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
       mov       rdx,7FF94907FF98
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
       mov       rdx,7FF94907FF80
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DB1900
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DB1900
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DB1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99566B438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99536D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,205B3800310
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,205A1802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,205A1802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99536D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,205B3800048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,205A1802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,205A1802028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F21C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99536D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,205B3800328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,205A1802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,205A1802028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F21C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF99564F790
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
       mov       rdx,7FF99564F848
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
       mov       rdx,7FF99564F830
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
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
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
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490AFEE0
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
       mov       rdx,7FF9490AFF98
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
       mov       rdx,7FF9490AFF80
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DE1900
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DE1900
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DE1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99487B438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99456D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,29FC3C12FE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,29FC3C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29FC3C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99456D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,29FC3C12D18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,29FC3C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,29FC3C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994121C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99456D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99456BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99456D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99456D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994123510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99456D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99456D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,29FC3C12FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,29FC3C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,29FC3C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994121C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99456D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99456BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99456D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99456D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994123510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99456D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF99485FF50
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
       mov       rdx,7FF994880018
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
       mov       rdx,7FF994880000
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
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF99456D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99456BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99456D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99456D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994123510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99456D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99436D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994341C78]
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
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94907FEE0
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
       mov       rdx,7FF94907FF98
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
       mov       rdx,7FF94907FF80
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DB1900
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DB1900
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DB1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99485B138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99454D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M01_L17
       lea       rcx,[r15+0C]
       mov       rdx,21E5C800310
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9941499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[r15+14]
       mov       rdx,21E60802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21E60802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FF99454D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L21
       lea       rcx,[rdi+0C]
       mov       rdx,21E5C800048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9941499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[rdi+12]
       mov       rdx,21E60802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,21E60802028
       mov       rdx,[rdx]
       call      qword ptr [7FF994101C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99454D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99454BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99454D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99454D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99434D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994103510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99454D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99434D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rsi,rsi
       jne       near ptr M01_L09
       call      qword ptr [7FF99454D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,21E5C800328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9941499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,21E60802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,21E60802028
       mov       rdx,[rdx]
       call      qword ptr [7FF994101C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99454D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99454BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99454D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99454D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99434D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994103510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99454D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99434D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       qword ptr [r14+30],0
       je        short M01_L10
       mov       r11,[r14+30]
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF99483FF60
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
       mov       rdx,7FF994860018
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
       mov       rdx,7FF994860000
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
       call      qword ptr [7FF994321C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994321C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      qword ptr [7FF99454D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99454BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99454D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99454D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99434D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994103510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99454D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99434D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994321C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994321C78]
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
       call      qword ptr [7FF994321C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994321C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490C0950
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DD1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99535D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1B8A9C12FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,1B8A9C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,1B8A9C02028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF99565B4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9956832D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF99535D5D0]
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
       jmp       qword ptr [7FF994F59A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF995794890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF99565DCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9957948A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF994E7B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF995794890
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
       mov       rdx,7FF995794B30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF995681048]
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
       mov       rdx,7FF995794B30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF995681018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF995794B50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF994CD0AA8
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
       mov       rdx,7FF995794B70
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
       call      qword ptr [7FF995671BF8]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF994CD0AA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF994CD0AB0
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
       mov       rdx,7FF995161898
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF99515D960]
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
       mov       r11,7FF994CD0AB0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490B0950
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DC1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99535D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1CF24000328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,1CF28002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,1CF28002028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF99564D4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9956852D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF99535D5D0]
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
       jmp       qword ptr [7FF994F59A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF995794F58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF99564FCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF995794F70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF994E7B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF995794F58
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
       mov       rdx,7FF9957951F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF995683048]
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
       mov       rdx,7FF9957951F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF995683018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF995795218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF994CD0AB0
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
       mov       rdx,7FF995795238
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
       call      qword ptr [7FF995671F58]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF994CD0AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF994CD0AB8
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
       mov       rdx,7FF995161898
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF99515D960]
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
       mov       r11,7FF994CD0AB8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490D0950
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DE1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99535D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1DA86812FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,1DA86802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,1DA86802028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF99566B4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9956932D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF99535D5D0]
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
       jmp       qword ptr [7FF994F59A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9957A3C28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF99566DCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9957A3C40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF994E7B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF9957A3C28
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
       mov       rdx,offset System.Runtime.CompilerServices.Unsafe.As[[System.Byte, System.Private.CoreLib],[System.UInt32, System.Private.CoreLib]](Byte ByRef)
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF995691048]
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
       mov       rdx,offset System.Runtime.CompilerServices.Unsafe.As[[System.Byte, System.Private.CoreLib],[System.UInt32, System.Private.CoreLib]](Byte ByRef)
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF995691018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF9957A3EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF994CD0AB0
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
       mov       rdx,7FF9957A3F08
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
       call      qword ptr [7FF995682560]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF994CD0AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF994CD0AB8
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
       mov       rdx,7FF995161898
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF99515D960]
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
       mov       r11,7FF994CD0AB8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490B0598
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DC1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99536D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,16712000328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,16704002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,16704002028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF99567D4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9956952D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF99536D5D0]
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
       jmp       qword ptr [7FF994F69A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9957B00F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF99567FCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9957B0108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF994E8B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF9957B00F0
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
       mov       rdx,offset System.Runtime.CompilerServices.Unsafe.As[[System.Byte, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](Byte ByRef)
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF995693048]
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
       mov       rdx,offset System.Runtime.CompilerServices.Unsafe.As[[System.Byte, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](Byte ByRef)
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF995693018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF9957B03B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF994CE0AB0
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
       mov       rdx,7FF9957B03D0
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
       call      qword ptr [7FF995682FE0]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF994CE0AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF994CE0AB8
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
       mov       rdx,7FF995171898
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF99516D960]
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
       mov       r11,7FF994CE0AB8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490A0598
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DB1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99536D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,14D60800328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,14D52802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,14D52802028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF99567D7B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9956A52D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF99536D5D0]
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
       jmp       qword ptr [7FF994F69A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9957B31C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF99567FCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF9957B31E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF994E8B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF9957B31C8
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
       mov       rdx,7FF9957B3468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9956A3048]
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
       mov       rdx,7FF9957B3468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9956A3018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF9957B3488
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF994CE0AB0
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
       mov       rdx,7FF9957B34A8
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
       call      qword ptr [7FF995682B60]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF994CE0AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF994CE0AB8
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
       mov       rdx,7FF995171898
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF99516D960]
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
       mov       r11,7FF994CE0AB8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490D0950
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DE1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99455D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1BADF000328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9941599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,1BAE3002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,1BAE3002028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF99485B4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9948832D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF994331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF99455D5D0]
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
       jmp       qword ptr [7FF994159A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF994968138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF99485DCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF994968150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF99407B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF994968138
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
       mov       rdx,7FF9949683D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF994881048]
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
       mov       rdx,7FF9949683D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF994881018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF9949683F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF993ED0AB0
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
       mov       rdx,7FF994968418
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
       call      qword ptr [7FF994871AE8]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF993ED0AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF993ED0AB8
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
       mov       rdx,7FF994361898
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF99435D960]
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
       mov       r11,7FF993ED0AB8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490D0950
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DE1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99457D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0A
       jl        near ptr M00_L02
       lea       rcx,[rbx+0C]
       mov       rdx,21FFB012FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M00_L03
       lea       rcx,[rbx+20]
       mov       rdx,21FFB002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       cmp       dword ptr [rcx+8],0
       je        short M00_L00
       jmp       near ptr M00_L04
M00_L00:
       mov       rcx,21FFB002028
       mov       rcx,[rcx]
       jmp       near ptr M00_L04
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF99486D4B0]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9948A52D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       call      qword ptr [7FF99457D5D0]
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
       jmp       qword ptr [7FF994179A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF994986338
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF99486FCA8]; System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rbx
       mov       rdx,[r14+48]
       test      rdx,rdx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FF994986350
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FF99409B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF994986338
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
       mov       rdx,7FF9949865D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FF9948A3048]
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
       mov       rdx,7FF9949865D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L11:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9948A3018]; System.Collections.Generic.SortedSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF9949865F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       rcx,rsi
       mov       r11,7FF993EF0AB0
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
       mov       rdx,7FF994986618
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
       call      qword ptr [7FF994891A28]; System.Collections.Generic.TreeSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF993EF0AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
M02_L17:
       mov       rcx,rsi
       mov       r11,7FF993EF0AB8
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
       mov       rdx,7FF994381898
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF99437D960]
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
       mov       r11,7FF993EF0AB8
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94906FDE0
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
       mov       rdx,7FF9490902C8
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
       mov       rdx,7FF94906FFD0
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
       mov       rdx,7FF949090298
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
       mov       rdx,7FF9490902B0
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
       mov       rdx,7FF949090120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9488F0970
       call      qword ptr [7FF9488F0970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF949090138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9488F0978
       call      qword ptr [7FF9488F0978]
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
       mov       r11,7FF9488F0980
       call      qword ptr [7FF9488F0980]
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
       mov       r11,7FF9488F0980
       call      qword ptr [7FF9488F0980]
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
       mov       rdx,7FF9490908A0
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
       mov       rdx,7FF949090958
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
       mov       rdx,7FF949090940
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DA1900
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DA1900
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DA1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99563D198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF99563D138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99514B7E0]
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
       mov       rdx,7FF99562FE10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF994E6B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF9956502D8
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
       mov       rdx,7FF995650000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF994E6B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF9956502A8
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
       mov       rdx,7FF9956502C0
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
       mov       rdx,7FF995650130
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF994CC0AC8
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
       mov       rdx,7FF995650148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF994CC0AD0
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
       mov       r11,7FF994CC0AD8
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
       call      qword ptr [7FF99514B780]
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
       mov       r11,7FF994CC0AD8
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
       call      qword ptr [7FF99534D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,2CDF5412FE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,2CDF5402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2CDF5402028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF99534D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,2CDF5412D18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,2CDF5402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2CDF5402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF99534D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,2CDF5412FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,2CDF5402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2CDF5402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF9956508C8
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
       mov       rdx,7FF995650980
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
       mov       rdx,7FF995650968
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94907FDE0
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
       mov       rdx,7FF9490A02C8
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
       mov       rdx,7FF94907FFD0
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
       mov       rdx,7FF9490A0298
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
       mov       rdx,7FF9490A02B0
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
       mov       rdx,7FF9490A0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF948900970
       call      qword ptr [7FF948900970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9490A0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF948900978
       call      qword ptr [7FF948900978]
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
       mov       r11,7FF948900980
       call      qword ptr [7FF948900980]
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
       mov       r11,7FF948900980
       call      qword ptr [7FF948900980]
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
       mov       rdx,7FF9490A08A0
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
       mov       rdx,7FF9490A0958
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
       mov       rdx,7FF9490A0940
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DB1900
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DB1900
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
       mov       rdx,7FF948DB1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DB1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99564B198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF99564B138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99514B7E0]
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
       mov       rdx,7FF9956503A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF994E6B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF995650868
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
       mov       rdx,7FF995650590
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF994E6B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF995650838
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
       mov       rdx,7FF995650850
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
       mov       rdx,7FF9956506C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF994CC0AD0
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
       mov       rdx,7FF9956506D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF994CC0AD8
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
       mov       r11,7FF994CC0AE0
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
       call      qword ptr [7FF99514B780]
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
       mov       r11,7FF994CC0AE0
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
       call      qword ptr [7FF99534D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,21415412FE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,21415402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21415402028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF99534D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,21415412D18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,21415402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,21415402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF99534D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,21415412FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,21415402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,21415402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF995650E58
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
       mov       rdx,7FF995650F10
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
       mov       rdx,7FF995650EF8
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94906FDE0
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
       mov       rdx,7FF9490902C8
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
       mov       rdx,7FF94906FFD0
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
       mov       rdx,7FF949090298
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
       mov       rdx,7FF9490902B0
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
       mov       rdx,7FF949090120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9488F0970
       call      qword ptr [7FF9488F0970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF949090138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9488F0978
       call      qword ptr [7FF9488F0978]
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
       mov       r11,7FF9488F0980
       call      qword ptr [7FF9488F0980]
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
       mov       r11,7FF9488F0980
       call      qword ptr [7FF9488F0980]
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
       mov       rdx,7FF9490908A0
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
       mov       rdx,7FF949090958
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
       mov       rdx,7FF949090940
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DA1900
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DA1900
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
       mov       rdx,7FF948DA1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DA1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99566BA38]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF99566B9D8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99516B7E0]
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
       mov       rdx,7FF995670000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF994E8B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF9956704C8
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
       mov       rdx,7FF9956701F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF994E8B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF995670498
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
       mov       rdx,7FF9956704B0
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
       mov       rdx,7FF995670320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF994CE0AD0
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
       mov       rdx,7FF995670338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF994CE0AD8
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
       mov       r11,7FF994CE0AE0
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
       call      qword ptr [7FF99516B780]
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
       mov       r11,7FF994CE0AE0
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
       call      qword ptr [7FF99536D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,1DECE000310
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,1DECC002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1DECC002028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF99536D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1DECE000048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,1DECC002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1DECC002028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F21C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF99536D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1DECE000328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,1DECC002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1DECC002028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F21C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF995670AB8
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
       mov       rdx,7FF995670B70
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
       mov       rdx,7FF995670B58
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
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF99536D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951C1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99536BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99536D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99536D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99536D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99516D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
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
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995141C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94909FDE0
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
       mov       rdx,7FF9490C02C8
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
       mov       rdx,7FF94909FFD0
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
       mov       rdx,7FF9490C0298
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
       mov       rdx,7FF9490C02B0
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
       mov       rdx,7FF9490C0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF948920970
       call      qword ptr [7FF948920970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9490C0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF948920978
       call      qword ptr [7FF948920978]
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
       mov       r11,7FF948920980
       call      qword ptr [7FF948920980]
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
       mov       r11,7FF948920980
       call      qword ptr [7FF948920980]
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
       mov       rdx,7FF9490C08A0
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
       mov       rdx,7FF9490C0958
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
       mov       rdx,7FF9490C0940
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DD1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99564BA38]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF99564B9D8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99514B7E0]
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
       mov       rdx,7FF99562F9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF994E6B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF99562FE78
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
       mov       rdx,7FF99562FBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF994E6B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF99562FE48
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
       mov       rdx,7FF99562FE60
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
       mov       rdx,7FF99562FCD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF994CC0AD0
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
       mov       rdx,7FF99562FCE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF994CC0AD8
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
       mov       r11,7FF994CC0AE0
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
       call      qword ptr [7FF99514B780]
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
       mov       r11,7FF994CC0AE0
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
       call      qword ptr [7FF99534D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,1B858C12FE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,1B858C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B858C02028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF99534D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1B858C12D18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,1B858C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1B858C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF99534D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1B858C12FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,1B858C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1B858C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F01C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF995650470
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
       mov       rdx,7FF995650528
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
       mov       rdx,7FF995650510
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF99534D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951A1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99534BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99534D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99534D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99534D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99514D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
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
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995121C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94909F9E8
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
       mov       rdx,7FF94909FEB0
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
       mov       rdx,7FF94909FBD8
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
       mov       rdx,7FF94909FE80
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
       mov       rdx,7FF94909FE98
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
       mov       rdx,7FF94909FD08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF948920970
       call      qword ptr [7FF948920970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF94909FD20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF948920978
       call      qword ptr [7FF948920978]
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
       mov       r11,7FF948920980
       call      qword ptr [7FF948920980]
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
       mov       r11,7FF948920980
       call      qword ptr [7FF948920980]
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
       mov       rdx,7FF9490C0530
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
       mov       rdx,7FF9490C05E8
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
       mov       rdx,7FF9490C05D0
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DD1900
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
       mov       rdx,7FF948DD1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DD1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99565B4C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF99565B468]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99515B7E0]
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
       mov       rdx,7FF99563F848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF994E7B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF99563FD10
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
       mov       rdx,7FF99563FA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF994E7B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF99563FCE0
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
       mov       rdx,7FF99563FCF8
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
       mov       rdx,7FF99563FB68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF994CD0AD0
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
       mov       rdx,7FF99563FB80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF994CD0AD8
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
       mov       r11,7FF994CD0AE0
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
       call      qword ptr [7FF99515B780]
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
       mov       r11,7FF994CD0AE0
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
       call      qword ptr [7FF99535D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,1BA20412FE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,1BA20402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1BA20402028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF99535D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1BA20412D18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,1BA20402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1BA20402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F11C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF99535D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1BA20412FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,1BA20402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF994F599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1BA20402028
       mov       rdx,[rdx]
       call      qword ptr [7FF994F11C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF995660300
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
       mov       rdx,7FF9956603B8
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
       mov       rdx,7FF9956603A0
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF99535D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9951B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99535BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99535D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99535D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994F13510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99535D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99515D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
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
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF995131C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF94908FDE0
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
       mov       rdx,7FF9490B02C8
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
       mov       rdx,7FF94908FFD0
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
       mov       rdx,7FF9490B0298
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
       mov       rdx,7FF9490B02B0
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
       mov       rdx,7FF9490B0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF948910970
       call      qword ptr [7FF948910970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9490B0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF948910978
       call      qword ptr [7FF948910978]
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
       mov       r11,7FF948910980
       call      qword ptr [7FF948910980]
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
       mov       r11,7FF948910980
       call      qword ptr [7FF948910980]
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
       mov       rdx,7FF9490B08A0
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
       mov       rdx,7FF9490B0958
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
       mov       rdx,7FF9490B0940
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DC1900
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
       mov       rdx,7FF948DC1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DC1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99487BD38]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF99487BCD8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99437B7E0]
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
       mov       rdx,7FF99485FFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF99409B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF9948804B8
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
       mov       rdx,7FF9948801E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF99409B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF994880488
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
       mov       rdx,7FF9948804A0
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
       mov       rdx,7FF994880310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF993EF0AD0
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
       mov       rdx,7FF994880328
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF993EF0AD8
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
       mov       r11,7FF993EF0AE0
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
       call      qword ptr [7FF99437B780]
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
       mov       r11,7FF993EF0AE0
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
       call      qword ptr [7FF99457D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,1795A012FE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,1795A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1795A002028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF99457D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,1795A012D18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,1795A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1795A002028
       mov       rdx,[rdx]
       call      qword ptr [7FF994131C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99457D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99457BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99457D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99457D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994133510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99457D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF99457D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,1795A012FF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,1795A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1795A002028
       mov       rdx,[rdx]
       call      qword ptr [7FF994131C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99457D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99457BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99457D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99457D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994133510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99457D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF994880AA8
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
       mov       rdx,7FF994880B60
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
       mov       rdx,7FF994880B48
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
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF99457D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943D1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99457BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99457D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99457D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994133510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99457D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99437D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
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
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FF9490AFDE0
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
       mov       rdx,7FF9490D02C8
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
       mov       rdx,7FF9490AFFD0
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
       mov       rdx,7FF9490D0298
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
       mov       rdx,7FF9490D02B0
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
       mov       rdx,7FF9490D0120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF948930970
       call      qword ptr [7FF948930970]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9490D0138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF948930978
       call      qword ptr [7FF948930978]
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
       mov       r11,7FF948930980
       call      qword ptr [7FF948930980]
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
       mov       r11,7FF948930980
       call      qword ptr [7FF948930980]
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
       mov       rdx,7FF9490D08A0
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
       mov       rdx,7FF9490D0958
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
       mov       rdx,7FF9490D0940
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,97
       mov       rdx,7FF948DE1900
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,215
       mov       rdx,7FF948DE1900
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
       mov       rdx,7FF948DE1900
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF948DE1900
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF99486B4C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF99486B468]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF99435B7E0]
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
       mov       rdx,7FF99484FED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF99407B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF994870398
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
       mov       rdx,7FF9948700C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF99407B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF994870368
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
       mov       rdx,7FF994870380
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
       mov       rdx,7FF9948701F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF993ED0AD0
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
       mov       rdx,7FF994870208
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF993ED0AD8
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
       mov       r11,7FF993ED0AE0
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
       call      qword ptr [7FF99435B780]
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
       mov       r11,7FF993ED0AE0
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
       call      qword ptr [7FF99455D378]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],4
       jl        near ptr M02_L17
       lea       rcx,[r15+0C]
       mov       rdx,17CAEC00310
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FF9941599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M02_L18
       lea       rcx,[r15+14]
       mov       rdx,17CB2C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,17CB2C02028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
       test      rdi,rdi
       setne     al
       test      eax,eax
       jne       near ptr M02_L06
       call      qword ptr [7FF99455D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M02_L21
       lea       rcx,[rdi+0C]
       mov       rdx,17CAEC00048
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FF9941599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L22
       lea       rcx,[rdi+12]
       mov       rdx,17CB2C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,17CB2C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994111C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99455D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99455BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99455D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99455D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99435D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994113510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99455D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99435D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       test      rsi,rsi
       jne       near ptr M02_L09
       call      qword ptr [7FF99455D378]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M02_L24
       lea       rcx,[rsi+0C]
       mov       rdx,17CAEC00328
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF9941599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M02_L25
       lea       rcx,[rsi+20]
       mov       rdx,17CB2C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9941599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,17CB2C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF994111C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF99455D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99455BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99455D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99455D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99435D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994113510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99455D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99435D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       cmp       qword ptr [r14+30],0
       je        short M02_L10
       mov       r11,[r14+30]
       jmp       short M02_L11
M02_L10:
       mov       rcx,rbx
       mov       rdx,7FF994870988
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
       mov       rdx,7FF994870A40
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
       mov       rdx,7FF994870A28
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
       call      qword ptr [7FF994331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FF99455D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9943B1640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9943B1640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF99455BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF99455D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF99455D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF99435D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L20:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF994113510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF99455D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF99435D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994331C78]
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
       call      qword ptr [7FF994331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF994331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L26:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
; Total bytes of code 1598
```

