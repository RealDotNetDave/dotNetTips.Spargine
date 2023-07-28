## DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark-20230726-011958
**Diff for GetDescription01 method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,offset MT_System.StringComparison
        call      CORINFO_HELP_NEWSFAST
        mov       ecx,[rsi+190]
        mov       [rax+8],ecx
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
+       call      qword ptr [7FF9AAFA9FA8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9AAFAB120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 85
+; Total bytes of code 87
 ; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,20
+       sub       rsp,30
        mov       rsi,rcx
        test      rsi,rsi
-       setne     cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        near ptr M01_L01
+       jne       near ptr M01_L03
+       call      qword ptr [7FF9AAD6D378]
+       mov       ecx,7
+       call      System.String.FastAllocateString(Int32)
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],5
+       jl        near ptr M01_L05
+       lea       rcx,[rdi+0C]
+       mov       rdx,1308AC10848
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,0A
+       call      qword ptr [7FF9AA9599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rdi+8]
+       sub       ecx,5
+       cmp       ecx,2
+       jl        near ptr M01_L06
+       lea       rcx,[rdi+16]
+       mov       rdx,1308AC02090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FF9AA9599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [rdi+8],0
+       je        short M01_L02
+       mov       rcx,rdi
+M01_L00:
+       test      rcx,rcx
+       jne       short M01_L01
+       mov       eax,1
+       jmp       near ptr M01_L07
+M01_L01:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M01_L07
+M01_L02:
+       mov       rcx,1308AC02028
+       mov       rcx,[rcx]
+       jmp       short M01_L00
+M01_L03:
        mov       rcx,rsi
        call      System.Object.GetType()
        mov       rdi,rax
        mov       rcx,rsi
        mov       rax,[rsi]
-       mov       rbx,[rax+40]
-       call      qword ptr [rbx+8]
+       mov       rax,[rax+40]
+       mov       [rsp+28],rax
+       call      qword ptr [rax+8]
        mov       rdx,rax
        mov       rcx,rdi
        mov       r8d,1C
-       cmp       [rcx],ecx
-       call      qword ptr [7FF948A09648]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
+       call      qword ptr [7FF9AA7E8BD8]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
        mov       rdi,rax
        mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
        mov       rdx,rax
        mov       rcx,rdi
        xor       r8d,r8d
        mov       rax,[rdi]
        mov       rax,[rax+48]
        call      qword ptr [rax+28]
        mov       rdx,rax
        mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute[]
-       call      CORINFO_HELP_CHKCASTARRAY
+       call      qword ptr [7FF9AA87B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
        cmp       dword ptr [rax+8],0
-       jne       short M01_L00
+       jne       short M01_L04
        mov       rcx,rsi
-       mov       rax,[rbx+8]
-       add       rsp,20
+       mov       rax,[rsp+28]
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       rax
-M01_L00:
+       jmp       qword ptr [rax+8]
+M01_L04:
        mov       rcx,[rax+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
-       mov       rax,[rax+38]
-       add       rsp,20
+       add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       rax
-M01_L01:
-       mov       ecx,4D
-       mov       rdx,7FF948DA7F50
-       call      CORINFO_HELP_STRCNS
+       jmp       qword ptr [rax+38]
+M01_L05:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FF9AAB41C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L06:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       ecx,2F3
-       mov       rdx,7FF948DA7F50
+       mov       rcx,rsi
+       call      qword ptr [7FF9AAB41C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L07:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M01_L08
+       call      qword ptr [7FF9AAD6D498]
+       mov       rsi,rax
+       mov       ecx,340
+       mov       rdx,7FF9AABC19D8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
+       mov       ecx,6D0
+       mov       rdx,7FF9AABC19D8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FF9AAD6BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FF9AAD6D078]
+       mov       rdx,rax
        mov       rcx,rsi
+       call      qword ptr [7FF9AAD6D558]
+       mov       r8,rax
        mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
+       mov       rcx,rbx
+       call      qword ptr [7FF9AAB6D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L08:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FF9AA913510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FF9AAD6D078]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FF9AAB6D8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
        int       3
-; Total bytes of code 248
+; Total bytes of code 621
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
**Diff for GetItems01 method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,offset MT_System.StringComparison
        call      CORINFO_HELP_NEWSFAST
        mov       ecx,[rsi+190]
        mov       [rax+8],ecx
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
+       call      qword ptr [7FF9AAF8D420]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IList`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IList`1<System.ValueTuple`2<System.String,Int32>> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9AAF8DC90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 85
+; Total bytes of code 87
 ; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
        push      r15
        push      r14
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   xmmword ptr [rsp+28],xmm4
+       sub       rsp,50
        xor       eax,eax
-       mov       [rsp+38],rax
+       mov       [rsp+28],rax
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+30],xmm4
+       vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       rsi,rcx
        test      rsi,rsi
-       setne     cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        near ptr M01_L05
+       jne       near ptr M01_L03
+       call      qword ptr [7FF9AAD3D378]
+       mov       ecx,7
+       call      System.String.FastAllocateString(Int32)
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],5
+       jl        near ptr M01_L11
+       lea       rcx,[rdi+0C]
+       mov       rdx,2A372C0E438
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,0A
+       call      qword ptr [7FF9AA9499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rdi+8]
+       sub       ecx,5
+       cmp       ecx,2
+       jl        near ptr M01_L12
+       lea       rcx,[rdi+16]
+       mov       rdx,2A376C02090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FF9AA9499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [rdi+8],0
+       je        short M01_L02
+       mov       rcx,rdi
+M01_L00:
+       test      rcx,rcx
+       jne       short M01_L01
+       mov       eax,1
+       jmp       near ptr M01_L13
+M01_L01:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M01_L13
+M01_L02:
+       mov       rcx,2A376C02028
+       mov       rcx,[rcx]
+       jmp       short M01_L00
+M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rcx,7FF948A04938
-       mov       edx,46
-       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
-       mov       rdx,1398BF2D058
+       mov       rdx,2A372C0A770
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rcx,rsi
        call      System.Object.GetType()
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.Enum.GetNames(System.Type)
+       call      qword ptr [7FF9AA7E1648]; System.Enum.GetNames(System.Type)
        mov       rbx,rax
        xor       ebp,ebp
        mov       r14d,[rbx+8]
        test      r14d,r14d
-       jle       near ptr M01_L04
-M01_L00:
-       movsxd    rcx,ebp
+       jle       near ptr M01_L09
+M01_L04:
+       mov       ecx,ebp
        mov       r15,[rbx+rcx*8+10]
        mov       rcx,rsi
-       lea       rdx,[rsp+38]
+       test      r15,r15
+       je        near ptr M01_L10
+       lea       rdx,[r15+0C]
+       mov       r8d,[r15+8]
+       mov       [rsp+38],rdx
+       mov       [rsp+40],r8d
+       lea       rdx,[rsp+48]
        mov       [rsp+20],rdx
-       mov       rdx,r15
+       lea       rdx,[rsp+38]
        xor       r8d,r8d
        mov       r9d,1
-       call      System.Enum.TryParse(System.Type, System.String, Boolean, Boolean, System.Object ByRef)
-       mov       r12,[rsp+38]
+       call      qword ptr [7FF9AA7E17F8]; System.Enum.TryParse(System.Type, System.ReadOnlySpan`1<Char>, Boolean, Boolean, System.Object ByRef)
+       mov       r12,[rsp+48]
        xor       edx,edx
-       mov       [rsp+38],rdx
+       mov       [rsp+48],rdx
        mov       rdx,offset MT_System.Int32
        cmp       [r12],rdx
-       je        short M01_L01
-       mov       rdx,r12
-       mov       rcx,offset MT_System.Int32
-       call      CORINFO_HELP_UNBOX
-M01_L01:
+       jne       short M01_L06
+M01_L05:
        mov       r12d,[r12+8]
        mov       rdx,r15
        inc       dword ptr [rdi+14]
        mov       rcx,[rdi+8]
        mov       eax,[rdi+10]
-       cmp       [rcx+8],eax
-       jbe       short M01_L02
+       mov       r8d,[rcx+8]
+       cmp       r8d,eax
+       jbe       short M01_L07
        lea       r8d,[rax+1]
        mov       [rdi+10],r8d
-       movsxd    rax,eax
+       mov       eax,eax
        shl       rax,4
        lea       r15,[rcx+rax+10]
        mov       rcx,r15
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       [r15+8],r12d
-       jmp       short M01_L03
-M01_L02:
-       lea       rcx,[rsp+28]
-       mov       [rcx],rdx
-       mov       [rcx+8],r12d
+       jmp       short M01_L08
+M01_L06:
+       mov       rdx,r12
+       mov       rcx,offset MT_System.Int32
+       call      qword ptr [7FF9AA86B8D0]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
+       jmp       short M01_L05
+M01_L07:
+       mov       [rsp+28],rdx
+       mov       [rsp+30],r12d
        mov       rcx,rdi
        lea       rdx,[rsp+28]
-       call      System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,Int32>)
-M01_L03:
+       call      qword ptr [7FF9AAF8D618]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,Int32>)
+M01_L08:
        inc       ebp
        cmp       r14d,ebp
-       jg        near ptr M01_L00
-M01_L04:
+       jg        near ptr M01_L04
+M01_L09:
        mov       rax,rdi
-       add       rsp,40
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r14
        pop       r15
        ret
-M01_L05:
-       mov       ecx,4D
-       mov       rdx,7FF948D97F50
-       call      CORINFO_HELP_STRCNS
+M01_L10:
+       mov       ecx,7
+       call      qword ptr [7FF9AAB477B0]
+       int       3
+M01_L11:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FF9AAB21C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L12:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       ecx,2F3
-       mov       rdx,7FF948D97F50
+       mov       rcx,rsi
+       call      qword ptr [7FF9AAB21C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L13:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M01_L14
+       call      qword ptr [7FF9AAD3D498]
+       mov       rsi,rax
+       mov       ecx,340
+       mov       rdx,7FF9AABA1640
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
+       mov       ecx,6D0
+       mov       rdx,7FF9AABA1640
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FF9AAD3BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FF9AAD3D078]
+       mov       rdx,rax
        mov       rcx,rsi
+       call      qword ptr [7FF9AAD3D558]
+       mov       r8,rax
        mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
+       mov       rcx,rbx
+       call      qword ptr [7FF9AAB4D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L14:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FF9AA903510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FF9AAD3D078]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FF9AAB4D8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
        int       3
-; Total bytes of code 417
+; Total bytes of code 820
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
