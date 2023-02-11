## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       esi,edx
       mov       rdi,rcx
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,20C62933A38
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L00
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20C62933A30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,20C62933A38
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.Exception, System.Private.CoreLib]](System.Exception, System.Func`2<System.Exception,System.Exception>)
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rcx,20C62933A40
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L01
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20C62933A30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,20C62933A40
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       movzx     edx,si
       mov       [rsp+3C],dx
       lea       rdx,[rsp+3C]
       mov       ecx,1
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.String>)
       call      System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAC42BBA48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,363
       mov       rdx,7FFAC42BBA48
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
; Total bytes of code 399
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       edx,2C
       call      qword ptr [7FFAC52F3BA0]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52F5648]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 72
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       esi,edx
       mov       rdi,rcx
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFAC5209B40]
       mov       rdi,rax
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L05
       lea       rcx,[rsi+0C]
       mov       rdx,18879001B08
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFAC4EA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rsi+1E]
       mov       rdx,18875002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAC4EA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFAC4E61C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L07
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFAC5209C60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC5076190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC5076190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC5205270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC5209888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC5209D20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4FE1F18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4E63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC5209888]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4FE1F18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,18877002C58
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18877002C50
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC52F2CA8
       mov       [rbx+18],rdx
       mov       rcx,18877002C58
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M01_L03:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.Exception, System.Private.CoreLib]](System.Exception, System.Func`2<System.Exception,System.Exception>)
       call      qword ptr [7FFAC52F3D20]; DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rcx,18877002C60
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18877002C50
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC52F2CC0
       mov       [rbx+18],rdx
       mov       rcx,18877002C60
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M01_L04:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FFAC5195C18]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       [rsp+3C],si
       lea       rdx,[rsp+3C]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFAC52F54E0]; System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC5003C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC5003C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
; Total bytes of code 760
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

