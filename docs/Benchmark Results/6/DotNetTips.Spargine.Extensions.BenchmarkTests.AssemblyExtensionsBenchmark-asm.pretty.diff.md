## DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark-20240130-003417
**Diff for GetAllInterfaces01 method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllInterfaces01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       call      System.Reflection.Assembly.GetExecutingAssembly()
+       call      qword ptr [7FF9ECC91690]; System.Reflection.Assembly.GetExecutingAssembly()
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
+       call      qword ptr [7FF9ED149000]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9ED14D9C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 69
 ; System.Reflection.Assembly.GetExecutingAssembly()
        sub       rsp,28
        mov       dword ptr [rsp+20],1
        lea       rcx,[rsp+20]
-       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
+       call      qword ptr [7FF9ECC91678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 28
+; Total bytes of code 29
 ; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rsi,rcx
        test      rsi,rsi
-       setne     cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        near ptr M02_L02
+       jne       near ptr M02_L03
+       call      qword ptr [7FF9ECF0D378]
+       mov       ecx,0A
+       call      System.String.FastAllocateString(Int32)
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],8
+       jl        near ptr M02_L06
+       lea       rcx,[rdi+0C]
+       mov       rdx,28197411008
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,10
+       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rdi+8]
+       sub       ecx,8
+       cmp       ecx,2
+       jl        near ptr M02_L07
+       lea       rcx,[rdi+1C]
+       mov       rdx,28197402090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FF9ECAF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [rdi+8],0
+       je        short M02_L02
+       mov       rcx,rdi
+M02_L00:
+       test      rcx,rcx
+       jne       short M02_L01
+       mov       eax,1
+       jmp       near ptr M02_L08
+M02_L01:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M02_L08
+M02_L02:
+       mov       rcx,28197402028
+       mov       rcx,[rcx]
+       jmp       short M02_L00
+M02_L03:
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rcx,7FF9DB614938
-       mov       edx,46
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rdx,21FDF30F488
+       mov       rdx,2819740CBE0
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rsi
        mov       rax,[rsi]
        mov       rax,[rax+40]
        call      qword ptr [rax+28]
        mov       rsi,rax
        xor       ebx,ebx
        mov       ebp,[rsi+8]
        test      ebp,ebp
-       jle       short M02_L01
-M02_L00:
-       movsxd    rcx,ebx
+       jle       short M02_L05
+M02_L04:
+       mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rax,[rcx]
        mov       rax,[rax+98]
-       call      qword ptr [rax+8]
+       call      qword ptr [rax]
        mov       r8,rax
        mov       edx,[rdi+10]
        mov       rcx,rdi
-       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9ECBA7E28]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        inc       ebx
        cmp       ebp,ebx
-       jg        short M02_L00
-M02_L01:
+       jg        short M02_L04
+M02_L05:
        mov       rax,rdi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
-M02_L02:
-       mov       ecx,4D
-       mov       rdx,7FF9DB9B7FD0
-       call      CORINFO_HELP_STRCNS
+M02_L06:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FF9ECCE1C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L07:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       ecx,7B
-       mov       rdx,7FF9DB9B7FD0
+       mov       rcx,rsi
+       call      qword ptr [7FF9ECCE1C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L08:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M02_L09
+       call      qword ptr [7FF9ECF0D498]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FF9ECD518D0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
+       mov       ecx,8BA
+       mov       rdx,7FF9ECD518D0
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FF9ECF0BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FF9ECF0D078]
+       mov       rdx,rax
        mov       rcx,rsi
+       call      qword ptr [7FF9ECF0D600]
+       mov       r8,rax
        mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
+       mov       rcx,rbx
+       call      qword ptr [7FF9ECCFD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M02_L09:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FF9ECAB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FF9ECF0D078]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FF9ECCFD8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
        int       3
-; Total bytes of code 240
+; Total bytes of code 589
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
**Diff for GetAllTypes01 method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllTypes01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       call      System.Reflection.Assembly.GetExecutingAssembly()
+       call      qword ptr [7FF9ECC81690]; System.Reflection.Assembly.GetExecutingAssembly()
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
+       call      qword ptr [7FF9ED12B018]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9ED12F990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 69
 ; System.Reflection.Assembly.GetExecutingAssembly()
        sub       rsp,28
        mov       dword ptr [rsp+20],1
        lea       rcx,[rsp+20]
-       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
+       call      qword ptr [7FF9ECC81678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 28
+; Total bytes of code 29
 ; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
        push      rdi
        push      rsi
-       sub       rsp,28
+       push      rbx
+       sub       rsp,30
        test      rcx,rcx
-       setne     al
-       movzx     eax,al
-       test      eax,eax
-       je        near ptr M02_L01
+       jne       near ptr M02_L03
+       call      qword ptr [7FF9ECEFD378]
+       mov       ecx,0A
+       call      System.String.FastAllocateString(Int32)
+       mov       rsi,rax
+       cmp       dword ptr [rsi+8],8
+       jl        near ptr M02_L05
+       lea       rcx,[rsi+0C]
+       mov       rdx,1B87B800B48
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,10
+       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rsi+8]
+       sub       ecx,8
+       cmp       ecx,2
+       jl        near ptr M02_L06
+       lea       rcx,[rsi+1C]
+       mov       rdx,1B883802090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FF9ECAE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [rsi+8],0
+       je        short M02_L02
+       mov       rcx,rsi
+M02_L00:
+       test      rcx,rcx
+       jne       short M02_L01
+       mov       eax,1
+       jmp       near ptr M02_L07
+M02_L01:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M02_L07
+M02_L02:
+       mov       rcx,1B883802028
+       mov       rcx,[rcx]
+       jmp       short M02_L00
+M02_L03:
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+28]
        mov       rsi,rax
-       mov       rcx,2599DEDE390
+       mov       rcx,1B88380D648
        mov       r8,[rcx]
        test      r8,r8
-       jne       short M02_L00
+       jne       short M02_L04
        mov       rcx,offset MT_System.Func`2[[System.Type, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2599DEDE388
+       mov       rdx,1B88380D640
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,offset DotNetTips.Spargine.Extensions.AssemblyExtensions+<>c.<GetAllTypes>b__1_0(System.Type)
        mov       [rdi+18],rdx
-       mov       rcx,2599DEDE390
+       mov       rcx,1B88380D648
        mov       rdx,rdi
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
-M02_L00:
+M02_L04:
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>, System.Func`2<System.Type,Boolean>)
-       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF9ECE0DCF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        nop
-       add       rsp,28
+       add       rsp,30
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
-M02_L01:
-       mov       ecx,4D
-       mov       rdx,7FF9DB9A7FD0
-       call      CORINFO_HELP_STRCNS
+M02_L05:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       ecx,7B
-       mov       rdx,7FF9DB9A7FD0
+       mov       rcx,rsi
+       call      qword ptr [7FF9ECCD1C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L06:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FF9ECCD1C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L07:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M02_L08
+       call      qword ptr [7FF9ECEFD498]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FF9ECD418D0
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
+       mov       ecx,8BA
+       mov       rdx,7FF9ECD418D0
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FF9ECEFBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FF9ECEFD078]
+       mov       rdx,rax
        mov       rcx,rsi
+       call      qword ptr [7FF9ECEFD600]
+       mov       r8,rax
        mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
+       mov       rcx,rbx
+       call      qword ptr [7FF9ECCED8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M02_L08:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FF9ECAA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FF9ECEFD078]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FF9ECCED8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
        int       3
-; Total bytes of code 229
+; Total bytes of code 602
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
**Diff for GetInstances01 method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances01()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       call      System.Reflection.Assembly.GetExecutingAssembly()
+       call      qword ptr [7FF9ECC91690]; System.Reflection.Assembly.GetExecutingAssembly()
        mov       rdi,rax
        mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]]
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        mov       dword ptr [rbx+28],0FFFFFFFE
        call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
        mov       [rbx+2C],eax
        lea       rcx,[rbx+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rsp+28],rbx
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9ED13BBB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 110
+; Total bytes of code 112
 ; System.Reflection.Assembly.GetExecutingAssembly()
        sub       rsp,28
        mov       dword ptr [rsp+20],1
        lea       rcx,[rsp+20]
-       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
+       call      qword ptr [7FF9ECC91678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 28
+; Total bytes of code 29
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
