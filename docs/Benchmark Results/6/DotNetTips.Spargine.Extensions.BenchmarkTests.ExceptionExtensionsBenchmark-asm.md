## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages01()
; 			this.Consumer.Consume(this._testException.GetAllMessages());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+10]
       mov       rcx,[rcx+0A8]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       esi,edx
       mov       rax,21134723020
       mov       rax,[rax]
       mov       [rsp+48],rax
       mov       rdi,rcx
       mov       rax,21114721F88
       mov       rax,[rax]
       mov       [rsp+40],rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+38],rax
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       rcx,2113472BF48
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L01
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2113472BF40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,2113472BF48
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy(!!0, System.Func`2<!!0,!!0>)
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rcx,2113472BF50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L02
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2113472BF40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,2113472BF50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       movzx     edx,si
       mov       [rsp+34],dx
       lea       rdx,[rsp+34]
       mov       ecx,1
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.String.JoinCore(System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 406
```

