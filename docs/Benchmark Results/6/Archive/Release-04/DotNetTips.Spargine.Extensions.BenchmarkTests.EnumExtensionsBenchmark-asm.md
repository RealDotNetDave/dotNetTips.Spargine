## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
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
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rbx,[rax+40]
       call      qword ptr [rbx+8]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1C
       cmp       [rcx],ecx
       call      qword ptr [7FF80E239638]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
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
       call      CORINFO_HELP_CHKCASTARRAY
       cmp       dword ptr [rax+8],0
       jne       short M01_L00
       mov       rcx,rsi
       mov       rax,[rbx+8]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L00:
       mov       rcx,[rax+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       mov       ecx,4D
       mov       rdx,7FF80E5DCF20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FF80E5DCF20
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
; Total bytes of code 248
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF81ADA1FA8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF81ADA3138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FF81AD0BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],5
       jl        near ptr M01_L05
       lea       rcx,[rdi+0C]
       mov       rdx,1B2224007A0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rdi+16]
       mov       rdx,1B222400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M01_L02
       mov       rcx,rdi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,1B222400030
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       mov       [rsp+28],rax
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1C
       call      qword ptr [7FF81A798BC0]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
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
       call      qword ptr [7FF81A82B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       cmp       dword ptr [rax+8],0
       jne       short M01_L04
       mov       rcx,rsi
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
M01_L04:
       mov       rcx,[rax+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+38]
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB01C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB01C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD0BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB729F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB729F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD0B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD0BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD0D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AABFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD0BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AABFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 621
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IList`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IList`1<System.ValueTuple`2<System.String,Int32>> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,7FF80E214928
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1A53E172F50
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Enum.GetNames(System.Type)
       mov       rbx,rax
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr M01_L04
M01_L00:
       movsxd    rcx,ebp
       mov       r15,[rbx+rcx*8+10]
       mov       rcx,rsi
       lea       rdx,[rsp+38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       xor       r8d,r8d
       mov       r9d,1
       call      System.Enum.TryParse(System.Type, System.String, Boolean, Boolean, System.Object ByRef)
       mov       r12,[rsp+38]
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       rdx,offset MT_System.Int32
       cmp       [r12],rdx
       je        short M01_L01
       mov       rdx,r12
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_UNBOX
M01_L01:
       mov       r12d,[r12+8]
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       short M01_L02
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       movsxd    rax,eax
       shl       rax,4
       lea       r15,[rcx+rax+10]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [r15+8],r12d
       jmp       short M01_L03
M01_L02:
       lea       rcx,[rsp+28]
       mov       [rcx],rdx
       mov       [rcx+8],r12d
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,Int32>)
M01_L03:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M01_L00
M01_L04:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L05:
       mov       ecx,4D
       mov       rdx,7FF80E5BCF20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FF80E5BCF20
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
; Total bytes of code 417
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF81ADA3720]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IList`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IList`1<System.ValueTuple`2<System.String,Int32>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF81ADA3F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FF81AD0BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],5
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1FA13800388
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+16]
       mov       rdx,1FA0F802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M01_L02
       mov       rcx,rdi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L13
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,1FA0F802028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1FA0F801F88
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81A7B1648]; System.Enum.GetNames(System.Type)
       mov       rbx,rax
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr M01_L09
M01_L04:
       mov       ecx,ebp
       mov       r15,[rbx+rcx*8+10]
       mov       rcx,rsi
       test      r15,r15
       je        near ptr M01_L10
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       lea       rdx,[rsp+48]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FF81A7B17F8]; System.Enum.TryParse(System.Type, System.ReadOnlySpan`1<Char>, Boolean, Boolean, System.Object ByRef)
       mov       r12,[rsp+48]
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       rdx,offset MT_System.Int32
       cmp       [r12],rdx
       jne       short M01_L06
M01_L05:
       mov       r12d,[r12+8]
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M01_L07
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       shl       rax,4
       lea       r15,[rcx+rax+10]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [r15+8],r12d
       jmp       short M01_L08
M01_L06:
       mov       rdx,r12
       mov       rcx,offset MT_System.Int32
       call      qword ptr [7FF81A83B8D0]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       jmp       short M01_L05
M01_L07:
       mov       [rsp+28],rdx
       mov       [rsp+30],r12d
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF81ADA3918]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,Int32>)
M01_L08:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M01_L04
M01_L09:
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L10:
       mov       ecx,7
       call      qword ptr [7FF81AB377B0]
       int       3
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FF81AD0BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD0B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD0BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD0D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD0BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 820
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

