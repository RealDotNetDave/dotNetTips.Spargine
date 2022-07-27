## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages01()
; 			base.Consumer.Consume(this._testException.GetAllMessages());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+20]
       mov       rcx,[rcx+0B8]
       mov       edx,2C
       call      00000000000093F8
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      000000000000B010
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
       je        near ptr 000000000000F0F5
       mov       rcx,1B21BADCE48
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000F036
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       rdx,1B21BADCE40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,1B21BADCE48
       mov       rdx,rbx
       call      000000000000B010
       mov       r8,rbx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy(!!0, System.Func`2<!!0,!!0>)
       call      0000000000009480
       mov       rdi,rax
       mov       rcx,1B21BADCE50
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000F0A8
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       rdx,1B21BADCE40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,1B21BADCE50
       mov       rdx,rbx
       call      000000000000B010
       mov       r8,rbx
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      0000000000001E50
       mov       r8,rax
       movzx     edx,si
       mov       [rsp+3C],dx
       lea       rdx,[rsp+3C]
       mov       ecx,1
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore(System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      000000000000ABB0
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,4D
       mov       rdx,7FF82F350C28
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,3AF
       mov       rdx,7FF82F350C28
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001960
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000000A18
       mov       rcx,rax
       call      000000000000FA80
       int       3
; Total bytes of code 399
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages01()
; 			base.Consumer.Consume(this._testException.GetAllMessages());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+20]
       mov       rcx,[rcx+0B8]
       mov       edx,2C
       call      qword ptr [3030]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
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
       jne       near ptr 000000000000E100
       call      qword ptr [9B28]
       mov       rdi,rax
       mov       ecx,0B
       call      000000000000A000
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr 000000000000E21B
       lea       rcx,[rsi+0C]
       mov       rdx,2D6BF813948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [5810]
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr 000000000000E23E
       lea       rcx,[rsi+1E]
       mov       rdx,2D6BF802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000E021
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000E026
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000E0C1
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF819D8
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF819D8
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       rcx,2D6BF80C068
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000E15D
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       rdx,2D6BF80C060
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,2D6BF80C068
       mov       rdx,rbx
       call      0000000000000010
       mov       r8,rbx
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy(!!0, System.Func`2<!!0,!!0>)
       call      qword ptr [3180]
       mov       rdi,rax
       mov       rcx,2D6BF80C070
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000E1D0
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       rdx,2D6BF80C060
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,2D6BF80C070
       mov       rdx,rbx
       call      0000000000000010
       mov       r8,rbx
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      qword ptr [9C18]
       mov       r8,rax
       mov       [rsp+3C],si
       lea       rdx,[rsp+3C]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore(System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      qword ptr [3930]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 754
```

