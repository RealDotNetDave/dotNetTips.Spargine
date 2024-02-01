## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
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
       mov       rcx,13E6E97E3D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L00
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,13E6E97E3C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,13E6E97E3D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.Exception, System.Private.CoreLib]](System.Exception, System.Func`2<System.Exception,System.Exception>)
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rcx,13E6E97E3D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L01
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,13E6E97E3C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,13E6E97E3D8
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
       mov       rdx,7FF9DB9A8198
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,37D
       mov       rdx,7FF9DB9A8198
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       edx,2C
       call      qword ptr [7FF9ED4F98A0]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ED4FB3F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       jne       near ptr M01_L03
       call      qword ptr [7FF9ED2CD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],9
       jl        near ptr M01_L06
       lea       rcx,[rbx+0C]
       mov       rdx,2564C8118A8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L07
       lea       rcx,[rbx+1E]
       mov       rdx,2564C800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9ECEB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L08
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,2564C800030
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,2564C80B690
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2564C80B688
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF9ED4F89A8
       mov       [rbx+18],rdx
       mov       rcx,2564C80B690
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M01_L04:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.Exception, System.Private.CoreLib]](System.Exception, System.Func`2<System.Exception,System.Exception>)
       call      qword ptr [7FF9ED4F9A20]; DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rcx,2564C80B698
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L05
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2564C80B688
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF9ED4F89C0
       mov       [rbx+18],rdx
       mov       rcx,2564C80B698
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M01_L05:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FF9ED217C18]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       mov       [rsp+3C],si
       lea       rdx,[rsp+3C]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FF9ED4FB288]; System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9ED0A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L09
       call      qword ptr [7FF9ED2CD498]
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
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9ECE73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9ED2CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9ED0BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 768
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

