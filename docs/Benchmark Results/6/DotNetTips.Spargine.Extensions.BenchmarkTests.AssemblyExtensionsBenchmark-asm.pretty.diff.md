## DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark-20221113-085945
**Diff for GetAllInterfaces01 method between:**
.NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
.NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllInterfaces01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       call      System.Reflection.Assembly.GetExecutingAssembly()
+       call      qword ptr [7FFAA77E3690]; System.Reflection.Assembly.GetExecutingAssembly()
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
+       call      qword ptr [7FFAA7B03B70]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFAA7B0F240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
+       call      qword ptr [7FFAA77E3678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
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
+       jne       near ptr M02_L02
+       call      qword ptr [7FFAA7A19B40]
+       mov       rsi,rax
+       mov       ecx,0A
+       call      System.String.FastAllocateString(Int32)
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],8
+       jl        near ptr M02_L05
+       lea       rcx,[rdi+0C]
+       mov       rdx,2647D004DD8
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,10
+       call      qword ptr [7FFAA76B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rdi+8]
+       sub       ecx,8
+       cmp       ecx,2
+       jl        near ptr M02_L06
+       lea       rcx,[rdi+1C]
+       mov       rdx,2647F002090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FFAA76B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       rcx,rdi
+       mov       rdx,rsi
+       call      qword ptr [7FFAA7671C60]; System.String.Concat(System.String, System.String)
+       mov       rcx,rax
+       test      rcx,rcx
+       jne       near ptr M02_L07
+       mov       eax,1
+M02_L00:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M02_L01
+       call      qword ptr [7FFAA7A19C60]
+       mov       rsi,rax
+       mov       ecx,9
+       mov       rdx,7FFAA78861D8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,3AD
+       mov       rdx,7FFAA78861D8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFAA7A15270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFAA7A19888]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFAA7A19D20]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFAA77F1F18]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M02_L01:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFAA7673510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFAA7A19888]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFAA77F1F18]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M02_L02:
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rcx,7FFAA9B14928
-       mov       edx,29
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rdx,27721E82FC0
+       mov       rdx,2647F001FF8
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
+       jle       short M02_L04
+M02_L03:
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
+       call      qword ptr [7FFAA76E7E28]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
        inc       ebx
        cmp       ebp,ebx
-       jg        short M02_L00
-M02_L01:
+       jg        short M02_L03
+M02_L04:
        mov       rax,rdi
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
-M02_L02:
-       mov       ecx,4D
-       mov       rdx,7FFAA9E29450
-       call      CORINFO_HELP_STRCNS
+M02_L05:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       ecx,7B
-       mov       rdx,7FFAA9E29450
-       call      CORINFO_HELP_STRCNS
-       mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
        mov       rcx,rsi
-       mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
-       int       3
-; Total bytes of code 240
+       call      qword ptr [7FFAA7813C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L06:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFAA7813C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L07:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M02_L00
+; Total bytes of code 581
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        mov       rdx,[r8]
        lea       rcx,[rcx+10]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        ret
 ; Total bytes of code 14
```
**Diff for GetAllTypes01 method between:**
.NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
.NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllTypes01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       call      System.Reflection.Assembly.GetExecutingAssembly()
+       call      qword ptr [7FFAA77D1690]; System.Reflection.Assembly.GetExecutingAssembly()
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
+       call      qword ptr [7FFAA7AF1B88]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFAA7AFBFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
+       call      qword ptr [7FFAA77D1678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
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
+       test      rcx,rcx
+       jne       near ptr M02_L02
+       call      qword ptr [7FFAA7A07B40]
+       mov       rsi,rax
+       mov       ecx,0A
+       call      System.String.FastAllocateString(Int32)
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],8
+       jl        near ptr M02_L04
+       lea       rcx,[rdi+0C]
+       mov       rdx,27418401E18
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,10
+       call      qword ptr [7FFAA76B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rdi+8]
+       sub       ecx,8
+       cmp       ecx,2
+       jl        near ptr M02_L05
+       lea       rcx,[rdi+1C]
+       mov       rdx,27414402090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FFAA76B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       rcx,rdi
+       mov       rdx,rsi
+       call      qword ptr [7FFAA7671C60]; System.String.Concat(System.String, System.String)
+       mov       rcx,rax
        test      rcx,rcx
-       setne     al
+       jne       near ptr M02_L06
+       mov       eax,1
+M02_L00:
+       test      eax,eax
+       sete      al
        movzx     eax,al
        test      eax,eax
-       je        near ptr M02_L01
+       jne       near ptr M02_L01
+       call      qword ptr [7FFAA7A07C60]
+       mov       rsi,rax
+       mov       ecx,9
+       mov       rdx,7FFAA78761D8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,3AD
+       mov       rdx,7FFAA78761D8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFAA7A03270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFAA7A07888]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFAA7A07D20]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFAA77DFF18]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M02_L01:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFAA7673510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFAA7A07888]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFAA77DFF18]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M02_L02:
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+28]
        mov       rsi,rax
-       mov       rcx,1EB27045DE0
+       mov       rcx,2741A402BF0
        mov       r8,[rcx]
        test      r8,r8
-       jne       short M02_L00
+       jne       short M02_L03
        mov       rcx,offset MT_System.Func`2[[System.Type, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EB27045DD8
+       mov       rdx,2741A402BE8
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,offset DotNetTips.Spargine.Extensions.AssemblyExtensions+<>c.<GetAllTypes>b__1_0(System.Type)
        mov       [rdi+18],rdx
-       mov       rcx,1EB27045DE0
+       mov       rcx,2741A402BF0
        mov       rdx,rdi
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
-M02_L00:
+M02_L03:
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>, System.Func`2<System.Type,Boolean>)
-       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFAA7959B58]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        nop
-       add       rsp,28
+       add       rsp,30
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
-M02_L01:
-       mov       ecx,4D
-       mov       rdx,7FFAA9E39450
-       call      CORINFO_HELP_STRCNS
+M02_L04:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       ecx,7B
-       mov       rdx,7FFAA9E39450
-       call      CORINFO_HELP_STRCNS
-       mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
        mov       rcx,rsi
-       mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
-       int       3
-; Total bytes of code 229
+       call      qword ptr [7FFAA7811C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L05:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFAA7811C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L06:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M02_L00
+; Total bytes of code 594
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        mov       rdx,[r8]
        lea       rcx,[rcx+10]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        ret
 ; Total bytes of code 14
```
**Diff for GetInstances01 method between:**
.NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
.NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
+       call      qword ptr [7FFAA77E1690]; System.Reflection.Assembly.GetExecutingAssembly()
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
+       call      qword ptr [7FFAA7B03348]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
+       call      qword ptr [7FFAA77E1678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 28
+; Total bytes of code 29
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        mov       rdx,[r8]
        lea       rcx,[rcx+10]
        call      CORINFO_HELP_ASSIGN_REF
        nop
        ret
 ; Total bytes of code 14
```
