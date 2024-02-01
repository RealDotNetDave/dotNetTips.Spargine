## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       mov       rdx,2CBC51A1C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2CB951A1568
       mov       r14,[rdx]
       mov       rdx,2CBC51A1C48
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,934
       mov       rdx,7FFF910E6728
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
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910E6728
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
; Total bytes of code 370
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2CB951A3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FFF8F8F5318]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F3DD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8F5438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F5CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,218A88084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF8F2499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,218A8802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F2499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L15
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L15
M01_L02:
       mov       rax,218A8802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,218B6801CB0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF8F3FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,218A8800528
       mov       r14,[rdx]
       mov       rdx,218B6801CB8
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF8F393FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF8F3FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        near ptr M01_L12
       cmp       ebp,ebx
       jg        short M01_L04
M01_L06:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L11
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F5CD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,218B6801CA8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F2499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,218A8802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F2499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,218A8802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F201C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F5CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F406C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F406C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F5CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F5CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F5CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F3CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F203510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F5CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F3CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F3FB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F391C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F391C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F5CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F406C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F406C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F5CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F5CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F5CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F3CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F203510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F5CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F3CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F391C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F391C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
; Total bytes of code 1136
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F2499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,218A8802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8EFB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8EFB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F22D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F395750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F1A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       mov       rdx,26883821C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,26823821568
       mov       r14,[rdx]
       mov       rdx,26883821C48
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       ecx,4D
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,934
       mov       rdx,7FFF910B6728
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
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910B6728
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
; Total bytes of code 370
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,26823823020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90C84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90C84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FFF8CD27318]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF8C80D0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8CD27438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       near ptr M01_L08
       call      qword ptr [7FFF8C9ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,183EB0084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,183EB002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L15
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L15
M01_L02:
       mov       rax,183EB002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,183FB000C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF8C82B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,183EB000528
       mov       r14,[rdx]
       mov       rdx,183FB000CA0
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF8C7C3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF8C82B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        near ptr M01_L12
       cmp       ebp,ebx
       jg        short M01_L04
M01_L06:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L11
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FFF8C9ED378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,183FB000C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,183EB002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,183EB002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C631C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8C82B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
; Total bytes of code 1136
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,183EB002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C65D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F2A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       mov       rdx,2391E351C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2389E351568
       mov       r14,[rdx]
       mov       rdx,2391E351C48
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       ecx,4D
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,934
       mov       rdx,7FFF910C6728
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
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910C6728
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
; Total bytes of code 370
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2389E353020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FFF8CD07888]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF8C7ED0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8CD079A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       near ptr M01_L08
       call      qword ptr [7FFF8C9CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,1F2104084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,1F210402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L15
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L15
M01_L02:
       mov       rax,1F210402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,1F21C400C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF8C80B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,1F210400528
       mov       r14,[rdx]
       mov       rdx,1F21C400CA0
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF8C7A3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF8C80B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        near ptr M01_L12
       cmp       ebp,ebx
       jg        short M01_L04
M01_L06:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L11
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FFF8C9CD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,1F21C400C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,1F210402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1F210402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C611C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8C9CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C816C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C816C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C613510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8C80B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8C9CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C816C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C816C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C613510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
; Total bytes of code 1136
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1F210402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C63D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F5A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       mov       rdx,1D095551C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1D0A5551568
       mov       r14,[rdx]
       mov       rdx,1D095551C48
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,934
       mov       rdx,7FFF910F6728
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
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910F6728
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
; Total bytes of code 370
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1D0A5553020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FFF8FD07018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F7DD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FD07138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,1B9DE8084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,1B9DE802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L15
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L15
M01_L02:
       mov       rax,1B9DE802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,1B9E2808C30
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,1B9DE800528
       mov       r14,[rdx]
       mov       rdx,1B9E2808C38
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF8F793FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        near ptr M01_L12
       cmp       ebp,ebx
       jg        short M01_L04
M01_L06:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L11
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,1B9E2808C28
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,1B9DE802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1B9DE802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
; Total bytes of code 1136
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1B9DE802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F4A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       mov       rdx,1F4429B1C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1F3B29B1568
       mov       r14,[rdx]
       mov       rdx,1F4429B1C48
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,934
       mov       rdx,7FFF910E6728
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
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910E6728
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
; Total bytes of code 370
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1F3B29B3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FFF8CD37018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF8C80D0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8CD37138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       near ptr M01_L08
       call      qword ptr [7FFF8C9ED378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,2950DC084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,2950DC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L15
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L15
M01_L02:
       mov       rax,2950DC02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,2950DC12840
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF8C82B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,2950DC00528
       mov       r14,[rdx]
       mov       rdx,2950DC12848
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF8C7C3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF8C82B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        near ptr M01_L12
       cmp       ebp,ebx
       jg        short M01_L04
M01_L06:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L11
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FFF8C9ED378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,2950DC12838
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,2950DC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2950DC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C631C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8C82B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
; Total bytes of code 1136
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2950DC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C65D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       mov       rdx,1BF09111C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1BF19111568
       mov       r14,[rdx]
       mov       rdx,1BF09111C48
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,934
       mov       rdx,7FFF910D6728
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
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910D6728
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
; Total bytes of code 370
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1BF19113020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCF7018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCF7138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,1F9A0404508
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,1F9A0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L15
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L15
M01_L02:
       mov       rax,1F9A0402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,1F9A040E868
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF8F7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,1F9A0400528
       mov       r14,[rdx]
       mov       rdx,1F9A040E870
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF8F783FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF8F7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        near ptr M01_L12
       cmp       ebp,ebx
       jg        short M01_L04
M01_L06:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L11
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,1F9A040E860
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,1F9A0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1F9A0402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
; Total bytes of code 1136
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1F9A0402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F4A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M01_L06
       mov       rdx,26D31271C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,26CA1271568
       mov       r14,[rdx]
       mov       rdx,26D31271C48
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,934
       mov       rdx,7FFF910E6728
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
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910E6728
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
; Total bytes of code 370
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,26CA1273020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCF9018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCF9138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,27DB40084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,27DB4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L15
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L15
M01_L02:
       mov       rax,27DB4002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,27DB4011828
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF8F7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,27DB4000528
       mov       r14,[rdx]
       mov       rdx,27DB4011830
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF8F783FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF8F7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L05:
       add       ebx,1
       jo        near ptr M01_L12
       cmp       ebp,ebx
       jg        short M01_L04
M01_L06:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L11
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,27DB4011820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,27DB4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,27DB4002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
; Total bytes of code 1136
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,27DB4002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,1FFBA049A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F2A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910C6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910C6728
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
; Total bytes of code 344
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1FFBA043020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,1DC47808A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCD7060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F99D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,1DC57800C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,1DC47802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L09
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
M01_L02:
       mov       rdx,1DC47802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F99D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1DC57800C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,1DC47802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1DC47802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5E1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L13
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCD7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCD7168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
; Total bytes of code 1084
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1DC47802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,17B22C69A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F5A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910F6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910F6728
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
; Total bytes of code 344
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,17B22C63020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,27129808A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8CD078D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF8C7ED0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8C9CD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,27133800C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,27129802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L09
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
M01_L02:
       mov       rdx,27129802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8C9CD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,27133800C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,27129802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,27129802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C611C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L13
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8C9CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C816C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C816C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C613510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF8CD07870]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8CD079D8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8C9CD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C816C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C816C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9CD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C613510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7DD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
; Total bytes of code 1084
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,27129802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C63D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C7A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,1BFDED59A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F1A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910B6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910B6728
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
; Total bytes of code 344
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1BFDED53020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90C84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90C84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,23000C08A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCD7060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F99D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,2300AC00C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,23000C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L09
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
M01_L02:
       mov       rdx,23000C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F99D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,2300AC00C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,23000C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,23000C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5E1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L13
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCD7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCD7168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
; Total bytes of code 1084
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,23000C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,2D645F89A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910D6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910D6728
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
; Total bytes of code 344
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2D645F83020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,1A5F8806A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCE9360]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F99D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,1A5F880F828
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,1A5F8800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L09
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
M01_L02:
       mov       rdx,1A5F8800030
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F99D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1A5F880F830
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,1A5F8800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1A5F8800030
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5E1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L13
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCE9300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCE9468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
; Total bytes of code 1084
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1A5F8800030
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,278251816B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910D6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910D6728
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
; Total bytes of code 344
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,27805183020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,176AA408A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8CD17360]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8C9DD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,176B6400C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,176AA402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L09
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
M01_L02:
       mov       rdx,176AA402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8C9DD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,176B6400C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,176AA402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,176AA402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C621C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L13
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8C9DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C623510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF8CD17300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8CD17468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8C9DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C623510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
; Total bytes of code 1084
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,176AA402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C64D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,2129CD09A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F5A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910F6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910F6728
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
; Total bytes of code 344
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2129CD03020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,14B44C08A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCF9060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F7DD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,14B4AC00C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,14B44C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L09
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
M01_L02:
       mov       rdx,14B44C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,14B4AC00C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,14B44C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,14B44C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L13
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCF9000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCF9168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
; Total bytes of code 1084
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,14B44C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,2859B739A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF90F4A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910E6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910E6728
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
; Total bytes of code 344
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2859B733020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+288]
       mov       rdx,18D65808A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCD7360]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F99D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,18D65811820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,18D65802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L09
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L09
M01_L02:
       mov       rdx,18D65802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F99D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,18D65811828
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,18D65802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,18D65802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5E1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L13
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCD7300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCD7468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF8F99D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7E6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F99BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F99D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F99D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F99D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
; Total bytes of code 1084
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,18D65802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,26545EE9A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910D6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2BD
       mov       rdx,7FFF910D6728
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910D6728
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
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,26545EE3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,1C6D4008A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCE7048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,1C6DC000C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,1C6D4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L12
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L12
M01_L02:
       mov       rdx,1C6D4002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,1C6DC000C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,1C6D4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1C6D4002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L16
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,1C6DC000CA0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,1C6D4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1C6D4002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCE7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCE7180]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1544
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1C6D4002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,27BCF759A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF90F5A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910F6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2BD
       mov       rdx,7FFF910F6728
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910F6728
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
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,27BCF753020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,228ACC08A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8CD25BB8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF8C80D0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8C9ED378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,228B4C00C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,228ACC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L12
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L12
M01_L02:
       mov       rdx,228ACC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8C9ED378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,228B4C00C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,228ACC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,228ACC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C631C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L16
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF8C9ED378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,228B4C00CA0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,228ACC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,228ACC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C631C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF8CD25B70]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8CD25CF0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1544
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,228ACC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C65D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,2A7659C9A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF90F2A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910C6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2BD
       mov       rdx,7FFF910C6728
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910C6728
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
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2A7659C3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,1DF17008A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FD07048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F7DD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,1DF17012838
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,1DF17002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L12
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L12
M01_L02:
       mov       rdx,1DF17002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,1DF17012840
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,1DF17002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1DF17002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L16
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,1DF17012848
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,1DF17002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1DF17002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF8FD07000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FD07180]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1544
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1DF17002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,1D0D0259A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF90F4A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910E6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2BD
       mov       rdx,7FFF910E6728
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910E6728
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
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1D0D0253020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,17D27008A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCE78B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,17D31000C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,17D27002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L12
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L12
M01_L02:
       mov       rdx,17D27002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,17D31000C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,17D27002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,17D27002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L16
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,17D31000CA0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,17D27002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,17D27002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCE7870]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCE79F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1544
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,17D27002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,2239E579A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910D6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2BD
       mov       rdx,7FFF910D6728
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910D6728
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
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2239E573020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,210DFC08A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8CD27048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8C9DD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,210E7C08C28
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,210DFC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L12
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L12
M01_L02:
       mov       rdx,210DFC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8C9DD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,210E7C08C30
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,210DFC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,210DFC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C621C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L16
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8C9DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C623510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF8C9DD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,210E7C08C38
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,210DFC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,210DFC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8C621C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8C9DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C623510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF8CD27000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8CD27180]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF8C9DD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C826C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9DD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C623510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1544
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,210DFC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C64D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C7B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,21121609A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF90F5A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910F6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2BD
       mov       rdx,7FFF910F6728
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910F6728
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
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,21121603020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,1DFBD008A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCE7048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,1DFBD012838
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,1DFBD002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L12
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L12
M01_L02:
       mov       rdx,1DFBD002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,1DFBD012840
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,1DFBD002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1DFBD002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L16
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,1DFBD012848
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,1DFBD002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1DFBD002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F5F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCE7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCE7180]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1544
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1DFBD002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,1FBBF099A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF90F4A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L01
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910E6728
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
M01_L01:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2BD
       mov       rdx,7FFF910E6728
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
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,98A
       mov       rdx,7FFF910E6728
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
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1FBBF093020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsi+290]
       mov       rdx,2743FC08A90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FCF7348]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F7DD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       jne       near ptr M01_L03
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,2743FC11820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,2743FC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L12
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L12
M01_L02:
       mov       rdx,2743FC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,2743FC11828
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,2743FC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2743FC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L16
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,2743FC11830
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,2743FC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2743FC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF8F601C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L19
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF8FCF7300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF8FCF7480]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
; Total bytes of code 1544
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2743FC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,2C877643020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFF90F45938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2C877647CB8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,2C857641C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,2C877641568
       mov       r15,[rdx]
       mov       rdx,2C857641C48
       mov       r12,[rdx]
M01_L01:
       cmp       edi,ebx
       jae       short M01_L04
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r12
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L05
       movsxd    rax,edi
       cmp       r14,rax
       jg        short M01_L01
M01_L02:
       mov       rcx,[rbp-38]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L06
       movsxd    r8,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L03:
       call      qword ptr [7FFF90F2A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L07
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       rcx,[rbp-38]
       jmp       short M01_L03
M01_L07:
       mov       rcx,2C877647CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF90F45938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2C877647CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
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
; Total bytes of code 436
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF8FCF7300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCF73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,2CF53C02028
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,2CF53C06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FBB5680]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,2CF63C00C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,2CF53C00528
       mov       r12,[rdx]
       mov       rdx,2CF63C00C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF8F793FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       add       ebx,1
       jo        short M01_L06
       movsxd    rax,ebx
       cmp       r15,rax
       jg        short M01_L01
M01_L03:
       mov       rcx,[rbp-40]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L07
       mov       r8d,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L04:
       call      qword ptr [7FFF8F7DD0F0]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FBB5688]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,2CF53C06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FBB5688]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 418
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1444B713020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFF90F55938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1444B717CB8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1449B711C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1444B711568
       mov       r15,[rdx]
       mov       rdx,1449B711C48
       mov       r12,[rdx]
M01_L01:
       cmp       edi,ebx
       jae       short M01_L04
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r12
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L05
       movsxd    rax,edi
       cmp       r14,rax
       jg        short M01_L01
M01_L02:
       mov       rcx,[rbp-38]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L06
       movsxd    r8,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L03:
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L07
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       rcx,[rbp-38]
       jmp       short M01_L03
M01_L07:
       mov       rcx,1444B717CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF90F55938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1444B717CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
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
; Total bytes of code 436
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF8CD27B70]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8CD27C48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1AD7CC02028
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,1AD7CC06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8CBE3558]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1AD7CC11820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF8C82B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1AD7CC00528
       mov       r12,[rdx]
       mov       rdx,1AD7CC11828
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF8C7C3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF8C82B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       add       ebx,1
       jo        short M01_L06
       movsxd    rax,ebx
       cmp       r15,rax
       jg        short M01_L01
M01_L03:
       mov       rcx,[rbp-40]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L07
       mov       r8d,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L04:
       call      qword ptr [7FFF8C80D0F0]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8C82B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8CBE3560]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1AD7CC06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8CBE3560]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 418
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1B1EE323020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFF90F75938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B1EE327CB8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1B23E321C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1B1EE321568
       mov       r15,[rdx]
       mov       rdx,1B23E321C48
       mov       r12,[rdx]
M01_L01:
       cmp       edi,ebx
       jae       short M01_L04
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r12
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L05
       movsxd    rax,edi
       cmp       r14,rax
       jg        short M01_L01
M01_L02:
       mov       rcx,[rbp-38]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L06
       movsxd    r8,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L03:
       call      qword ptr [7FFF90F5A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L07
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       rcx,[rbp-38]
       jmp       short M01_L03
M01_L07:
       mov       rcx,1B1EE327CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF90F75938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B1EE327CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
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
; Total bytes of code 436
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF8FCC7000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCC70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,254D3802028
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,254D3806D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FB818D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,254CF800C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,254D3800528
       mov       r12,[rdx]
       mov       rdx,254CF800C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF8F763FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       add       ebx,1
       jo        short M01_L06
       movsxd    rax,ebx
       cmp       r15,rax
       jg        short M01_L01
M01_L03:
       mov       rcx,[rbp-40]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L07
       mov       r8d,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L04:
       call      qword ptr [7FFF8F7AD0F0]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F7CB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB818D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,254D3806D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB818D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 418
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,149AA993020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFF90F55938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,149AA997CB8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,14A0A991C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,149AA991568
       mov       r15,[rdx]
       mov       rdx,14A0A991C48
       mov       r12,[rdx]
M01_L01:
       cmp       edi,ebx
       jae       short M01_L04
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r12
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L05
       movsxd    rax,edi
       cmp       r14,rax
       jg        short M01_L01
M01_L02:
       mov       rcx,[rbp-38]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L06
       movsxd    r8,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L03:
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L07
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       rcx,[rbp-38]
       jmp       short M01_L03
M01_L07:
       mov       rcx,149AA997CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF90F55938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,149AA997CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
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
; Total bytes of code 436
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF8FD07870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FD07948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,2BA15C02028
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,2BA15C06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FBC59C0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,2BA1FC00C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF8F80B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,2BA15C00528
       mov       r12,[rdx]
       mov       rdx,2BA1FC00C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF8F7A3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF8F80B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       add       ebx,1
       jo        short M01_L06
       movsxd    rax,ebx
       cmp       r15,rax
       jg        short M01_L01
M01_L03:
       mov       rcx,[rbp-40]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L07
       mov       r8d,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L04:
       call      qword ptr [7FFF8F7ED0F0]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F80B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FBC59C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,2BA15C06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FBC59C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 418
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,20FFAD33020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFF90F75938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20FFAD37CB8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,20FEAD31C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,20FFAD31568
       mov       r15,[rdx]
       mov       rdx,20FEAD31C48
       mov       r12,[rdx]
M01_L01:
       cmp       edi,ebx
       jae       short M01_L04
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r12
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L05
       movsxd    rax,edi
       cmp       r14,rax
       jg        short M01_L01
M01_L02:
       mov       rcx,[rbp-38]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L06
       movsxd    r8,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L03:
       call      qword ptr [7FFF90F5A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L07
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       rcx,[rbp-38]
       jmp       short M01_L03
M01_L07:
       mov       rcx,20FFAD37CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF90F75938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20FFAD37CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
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
; Total bytes of code 436
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF8CD09300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8CD093D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,1F2F7C02028
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,1F2F7C06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8CBC7460]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1F2F7C12838
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF8C80B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1F2F7C00528
       mov       r12,[rdx]
       mov       rdx,1F2F7C12840
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF8C7A3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF8C80B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       add       ebx,1
       jo        short M01_L06
       movsxd    rax,ebx
       cmp       r15,rax
       jg        short M01_L01
M01_L03:
       mov       rcx,[rbp-40]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L07
       mov       r8d,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L04:
       call      qword ptr [7FFF8C7ED0F0]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8C80B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8CBC7468]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1F2F7C06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8CBC7468]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 418
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,172487C3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFF90F55938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,172487C7CB8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,172A87C1C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,172487C1568
       mov       r15,[rdx]
       mov       rdx,172A87C1C48
       mov       r12,[rdx]
M01_L01:
       cmp       edi,ebx
       jae       short M01_L04
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r12
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L05
       movsxd    rax,edi
       cmp       r14,rax
       jg        short M01_L01
M01_L02:
       mov       rcx,[rbp-38]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L06
       movsxd    r8,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L03:
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L07
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       rcx,[rbp-38]
       jmp       short M01_L03
M01_L07:
       mov       rcx,172487C7CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF90F55938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,172487C7CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
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
; Total bytes of code 436
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF8FCD7300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCD73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,15597002028
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,15597006D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FB948F0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,155A7000C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF8F7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,15597000528
       mov       r12,[rdx]
       mov       rdx,155A7000C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF8F773FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF8F7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       add       ebx,1
       jo        short M01_L06
       movsxd    rax,ebx
       cmp       r15,rax
       jg        short M01_L01
M01_L03:
       mov       rcx,[rbp-40]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L07
       mov       r8d,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L04:
       call      qword ptr [7FFF8F7BD0F0]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F7DB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB948F8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,15597006D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB948F8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 418
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,2145C1D3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFF90F35938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2145C1D7CB8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,2145C1E37E8
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,2145C1D1568
       mov       r15,[rdx]
       mov       rdx,2145C1E37F0
       mov       r12,[rdx]
M01_L01:
       cmp       edi,ebx
       jae       short M01_L04
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r12
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L05
       movsxd    rax,edi
       cmp       r14,rax
       jg        short M01_L01
M01_L02:
       mov       rcx,[rbp-38]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L06
       movsxd    r8,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L03:
       call      qword ptr [7FFF90F1A610]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L07
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       rcx,[rbp-38]
       jmp       short M01_L03
M01_L07:
       mov       rcx,2145C1D7CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       lea       rbp,[rbp+60]
       mov       rcx,7FFF90F35938
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2145C1D7CB8
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
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
; Total bytes of code 436
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF8FCD9300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCD93D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rax,17A12C02028
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,17A12C06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF8FB86FE0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,17A12C11820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,17A12C00528
       mov       r12,[rdx]
       mov       rdx,17A12C11828
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF8F763FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       add       ebx,1
       jo        short M01_L06
       movsxd    rax,ebx
       cmp       r15,rax
       jg        short M01_L01
M01_L03:
       mov       rcx,[rbp-40]
       mov       edx,[rcx+18]
       mov       r8d,edx
       mov       rax,[rcx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L07
       mov       r8d,r8d
       mov       word ptr [rax+r8*2+10],27
       inc       edx
       mov       [rcx+18],edx
M01_L04:
       call      qword ptr [7FFF8F7AD0F0]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF8F7CB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB86FE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,17A12C06D50
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF8FB86FE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 418
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L23
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       cmp       dword ptr [rcx+8],0
       je        short M01_L03
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebp
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbp,rax
       mov       ecx,954
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,970
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L09:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L19
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L10
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L11:
       xor       ebx,ebx
       mov       rcx,7FFF910D6ED0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,215AE8C85C0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L17
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L22
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L13
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L14:
       cmp       r15d,ebp
       jae       near ptr M01_L24
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L15
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L16:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L22
       jmp       near ptr M01_L12
M01_L17:
       sub       ebp,ebx
       jo        near ptr M01_L22
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L18
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L20
M01_L18:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L20:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L21
       mov       rdx,215AE8C9A98
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910D6728
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
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 978
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,215AE8C3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFF8FCF7330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,28C12008C28
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,28C16002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rax,28C16002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,28C16007888
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F5F3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L10
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
M01_L06:
       cmp       ebp,ebx
       jae       near ptr M01_L32
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF8F7EB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L26
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L08
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L09
       jmp       short M01_L09
M01_L08:
       xor       eax,eax
M01_L09:
       test      eax,eax
       jne       near ptr M01_L11
       call      qword ptr [7FFF8F9AD498]
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF8F96AA90
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L12
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L13
       jmp       short M01_L13
M01_L12:
       xor       eax,eax
M01_L13:
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF8F9AD498]
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF8F96AA90
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebp
       test      rcx,rcx
       je        near ptr M01_L31
       mov       rdx,r12
       call      qword ptr [7FFF8F4C8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F9AD198]
       mov       r12,rax
       mov       rcx,28C12008C30
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF8F4D1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF8F9AD198]
       mov       r15,rax
       mov       rcx,28C12008C38
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF8F7EB288]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L19
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L23
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L03
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M01_L04
M01_L21:
       sub       ebx,r12d
       jo        near ptr M01_L26
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L24
M01_L22:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F7EB288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,28C16008A90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF8F7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L25:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L26:
       call      CORINFO_HELP_OVERFLOW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F7BD960]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2063
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,28C16002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF90F1A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L23
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       cmp       dword ptr [rcx+8],0
       je        short M01_L03
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebp
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbp,rax
       mov       ecx,954
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,970
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L09:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L19
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L10
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L11:
       xor       ebx,ebx
       mov       rcx,7FFF910B6ED0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,19DCBB285C0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L17
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L22
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L13
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L14:
       cmp       r15d,ebp
       jae       near ptr M01_L24
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L15
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L16:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L22
       jmp       near ptr M01_L12
M01_L17:
       sub       ebp,ebx
       jo        near ptr M01_L22
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L18
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L20
M01_L18:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L20:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L21
       mov       rdx,19DCBB29A98
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       mov       ecx,4D
       mov       rdx,7FFF910B6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910B6728
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
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 978
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,19DCBB23020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90C84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90C84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFF8CD27030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF8C80D0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF8C9ED378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1F0F8011820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,1F0F8002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rax,1F0F8002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8C82B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,1F0F8007888
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8C633660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8C82B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L10
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
M01_L06:
       cmp       ebp,ebx
       jae       near ptr M01_L32
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF8C82B3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L26
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L08
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L09
       jmp       short M01_L09
M01_L08:
       xor       eax,eax
M01_L09:
       test      eax,eax
       jne       near ptr M01_L11
       call      qword ptr [7FFF8C9ED498]
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF8C9AAA90
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF8C82B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L12
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L13
       jmp       short M01_L13
M01_L12:
       xor       eax,eax
M01_L13:
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF8C9ED498]
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF8C9AAA90
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebp
       test      rcx,rcx
       je        near ptr M01_L31
       mov       rdx,r12
       call      qword ptr [7FFF8C508D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8C9ED198]
       mov       r12,rax
       mov       rcx,1F0F8011828
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF8C511708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF8C9ED198]
       mov       r15,rax
       mov       rcx,1F0F8011830
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF8C82B288]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L19
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      qword ptr [7FFF8C82B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L23
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L03
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M01_L04
M01_L21:
       sub       ebx,r12d
       jo        near ptr M01_L26
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8C82B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L24
M01_L22:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8C82B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8C82B288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,1F0F8008A90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF8C82B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L25:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L26:
       call      CORINFO_HELP_OVERFLOW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF8C9ED498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C836C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9ED600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C633510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C7FD960]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2063
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1F0F8002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C65D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C7C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF90F2A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L23
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       cmp       dword ptr [rcx+8],0
       je        short M01_L03
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebp
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbp,rax
       mov       ecx,954
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,970
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L09:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L19
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L10
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L11:
       xor       ebx,ebx
       mov       rcx,7FFF910C6ED0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,19A705085C0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L17
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L22
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L13
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L14:
       cmp       r15d,ebp
       jae       near ptr M01_L24
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L15
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L16:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L22
       jmp       near ptr M01_L12
M01_L17:
       sub       ebp,ebx
       jo        near ptr M01_L22
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L18
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L20
M01_L18:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L20:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L21
       mov       rdx,19A70509A98
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       mov       ecx,4D
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910C6728
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
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 978
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,19A70503020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFF8FCE78A0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F9AD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,24A7E000C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,24A72002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rax,24A72002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,24A72007888
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F5F3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L10
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
M01_L06:
       cmp       ebp,ebx
       jae       near ptr M01_L32
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF8F7EB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L26
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L08
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L09
       jmp       short M01_L09
M01_L08:
       xor       eax,eax
M01_L09:
       test      eax,eax
       jne       near ptr M01_L11
       call      qword ptr [7FFF8F9AD498]
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF8F96AA90
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L12
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L13
       jmp       short M01_L13
M01_L12:
       xor       eax,eax
M01_L13:
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF8F9AD498]
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF8F96AA90
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebp
       test      rcx,rcx
       je        near ptr M01_L31
       mov       rdx,r12
       call      qword ptr [7FFF8F4C8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F9AD198]
       mov       r12,rax
       mov       rcx,24A7E000C98
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF8F4D1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF8F9AD198]
       mov       r15,rax
       mov       rcx,24A7E000CA0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF8F7EB288]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L19
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L23
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L03
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M01_L04
M01_L21:
       sub       ebx,r12d
       jo        near ptr M01_L26
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L24
M01_L22:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F7EB288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,24A72008A90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF8F7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L25:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L26:
       call      CORINFO_HELP_OVERFLOW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF8F9AD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7F6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9AD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F7BD960]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2063
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,24A72002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF90F3A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L23
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       cmp       dword ptr [rcx+8],0
       je        short M01_L03
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebp
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbp,rax
       mov       ecx,954
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,970
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L09:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L19
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L10
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L11:
       xor       ebx,ebx
       mov       rcx,7FFF910D6ED0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,131FA1385C0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L17
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L22
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L13
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L14:
       cmp       r15d,ebp
       jae       near ptr M01_L24
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L15
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L16:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L22
       jmp       near ptr M01_L12
M01_L17:
       sub       ebp,ebx
       jo        near ptr M01_L22
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L18
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L20
M01_L18:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L20:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L21
       mov       rdx,131FA139A98
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       mov       ecx,4D
       mov       rdx,7FFF910D6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910D6728
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
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 978
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,131FA133020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFF8FCF78A0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF8F7DD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,22C30001CA8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,22C2E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rax,22C2E002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,22C2E007888
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F603660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L10
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
M01_L06:
       cmp       ebp,ebx
       jae       near ptr M01_L32
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF8F7FB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L26
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L08
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L09
       jmp       short M01_L09
M01_L08:
       xor       eax,eax
M01_L09:
       test      eax,eax
       jne       near ptr M01_L11
       call      qword ptr [7FFF8F9BD498]
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF8F97AA90
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L12
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L13
       jmp       short M01_L13
M01_L12:
       xor       eax,eax
M01_L13:
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF8F9BD498]
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF8F97AA90
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebp
       test      rcx,rcx
       je        near ptr M01_L31
       mov       rdx,r12
       call      qword ptr [7FFF8F4D8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F9BD198]
       mov       r12,rax
       mov       rcx,22C30001CB0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF8F4E1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF8F9BD198]
       mov       r15,rax
       mov       rcx,22C30001CB8
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF8F7FB288]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L19
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L23
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L03
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M01_L04
M01_L21:
       sub       ebx,r12d
       jo        near ptr M01_L26
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L24
M01_L22:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F7FB288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,22C2E008A90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L25:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L26:
       call      CORINFO_HELP_OVERFLOW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F7CD960]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2063
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,22C2E002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF90F2A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L23
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       cmp       dword ptr [rcx+8],0
       je        short M01_L03
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebp
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbp,rax
       mov       ecx,954
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,970
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L09:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L19
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L10
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L11:
       xor       ebx,ebx
       mov       rcx,7FFF910C6ED0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,250E86585C0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L17
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L22
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L13
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L14:
       cmp       r15d,ebp
       jae       near ptr M01_L24
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L15
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L16:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L22
       jmp       near ptr M01_L12
M01_L17:
       sub       ebp,ebx
       jo        near ptr M01_L22
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L18
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L20
M01_L18:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L20:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L21
       mov       rdx,250E8659A98
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       mov       ecx,4D
       mov       rdx,7FFF910C6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910C6728
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
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 978
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,250E8653020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90C94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFF8CCF7330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF8C7DD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF8C9BD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1698A808C28
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,16986802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8C6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rax,16986802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8C7FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,16986807888
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8C603660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8C7FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L10
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
M01_L06:
       cmp       ebp,ebx
       jae       near ptr M01_L32
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF8C7FB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L26
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L08
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L09
       jmp       short M01_L09
M01_L08:
       xor       eax,eax
M01_L09:
       test      eax,eax
       jne       near ptr M01_L11
       call      qword ptr [7FFF8C9BD498]
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF8C97AA90
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF8C9BD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8C9BD600]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF8C7CD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF8C7FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L12
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L13
       jmp       short M01_L13
M01_L12:
       xor       eax,eax
M01_L13:
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF8C9BD498]
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF8C97AA90
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,536
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9BD078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8C9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebp
       test      rcx,rcx
       je        near ptr M01_L31
       mov       rdx,r12
       call      qword ptr [7FFF8C4D8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8C9BD198]
       mov       r12,rax
       mov       rcx,1698A808C30
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF8C9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF8C603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9BD090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF8C9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF8C4E1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF8C9BD198]
       mov       r15,rax
       mov       rcx,1698A808C38
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF8C9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF8C603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9BD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF8C9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF8C7FB288]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L19
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      qword ptr [7FFF8C7FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L23
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L03
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M01_L04
M01_L21:
       sub       ebx,r12d
       jo        near ptr M01_L26
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8C7FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L24
M01_L22:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8C7FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8C7FB288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,16986808A90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF8C7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L25:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L26:
       call      CORINFO_HELP_OVERFLOW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF8C9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8C806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8C9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8C9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8C9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8C7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8C603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8C9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8C7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF8C3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C7CD960]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2063
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8C6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,16986802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8C3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8C3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8C62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8C795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF90F4A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L23
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       cmp       dword ptr [rcx+8],0
       je        short M01_L03
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebp
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbp,rax
       mov       ecx,954
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,970
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L09:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L19
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L10
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L11:
       xor       ebx,ebx
       mov       rcx,7FFF910E6ED0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,1FE0B3285C0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L17
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L22
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L13
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L14:
       cmp       r15d,ebp
       jae       near ptr M01_L24
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L15
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L16:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L22
       jmp       near ptr M01_L12
M01_L17:
       sub       ebp,ebx
       jo        near ptr M01_L22
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L18
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L20
M01_L18:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L20:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L21
       mov       rdx,1FE0B329A98
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       mov       ecx,4D
       mov       rdx,7FFF910E6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910E6728
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
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 978
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1FE0B323020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFF8FD07030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF8F7DD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F9BD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,14108C11820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,14108C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rax,14108C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,14108C07888
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F603660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L10
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
M01_L06:
       cmp       ebp,ebx
       jae       near ptr M01_L32
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF8F7FB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L26
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L08
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L09
       jmp       short M01_L09
M01_L08:
       xor       eax,eax
M01_L09:
       test      eax,eax
       jne       near ptr M01_L11
       call      qword ptr [7FFF8F9BD498]
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF8F97AA90
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L12
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L13
       jmp       short M01_L13
M01_L12:
       xor       eax,eax
M01_L13:
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF8F9BD498]
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF8F97AA90
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebp
       test      rcx,rcx
       je        near ptr M01_L31
       mov       rdx,r12
       call      qword ptr [7FFF8F4D8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F9BD198]
       mov       r12,rax
       mov       rcx,14108C11828
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF8F4E1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF8F9BD198]
       mov       r15,rax
       mov       rcx,14108C11830
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF8F7FB288]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L19
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L23
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L03
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M01_L04
M01_L21:
       sub       ebx,r12d
       jo        near ptr M01_L26
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L24
M01_L22:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F7FB288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,14108C08A90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L25:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L26:
       call      CORINFO_HELP_OVERFLOW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF8F9BD498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F806C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F9BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F9BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F9BD600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F9BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F7CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F7CD960]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2063
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,14108C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF90F5A610]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L23
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       cmp       dword ptr [rcx+8],0
       je        short M01_L03
       xor       eax,eax
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebp
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbp,rax
       mov       ecx,954
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,970
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L09:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L19
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L10
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L11:
       xor       ebx,ebx
       mov       rcx,7FFF910F6ED0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,25B219585C0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L17
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L22
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L13
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L14:
       cmp       r15d,ebp
       jae       near ptr M01_L24
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L15
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L16:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L22
       jmp       near ptr M01_L12
M01_L17:
       sub       ebp,ebx
       jo        near ptr M01_L22
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L18
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L20
M01_L18:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L20:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L21
       mov       rdx,25B21959A98
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       mov       ecx,4D
       mov       rdx,7FFF910F6728
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,940
       mov       rdx,7FFF910F6728
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
M01_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 978
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,25B21953020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF90CC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFF8FCC7330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF8F7AD0F0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF8F98D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1CCA8C00C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,1CCA0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rax,1CCA0C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7CB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,1CCA0C07888
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F5D3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7CB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L10
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
M01_L06:
       cmp       ebp,ebx
       jae       near ptr M01_L32
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF8F7CB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L26
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L08
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L09
       jmp       short M01_L09
M01_L08:
       xor       eax,eax
M01_L09:
       test      eax,eax
       jne       near ptr M01_L11
       call      qword ptr [7FFF8F98D498]
       mov       rbx,rax
       mov       ecx,223
       mov       rdx,7FFF8F94AA90
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F98BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF8F98D078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF8F98D600]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF8F7CB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L12
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L13
       jmp       short M01_L13
M01_L12:
       xor       eax,eax
M01_L13:
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF8F98D498]
       mov       rdi,rax
       mov       ecx,22B
       mov       rdx,7FFF8F94AA90
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F98BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F98D078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF8F98D600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebp
       test      rcx,rcx
       je        near ptr M01_L31
       mov       rdx,r12
       call      qword ptr [7FFF8F4A8D08]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF8F98D198]
       mov       r12,rax
       mov       rcx,1CCA8C00C98
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF8F98D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F98BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F98D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F98D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F98D090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF8F98D600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F765750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF8F4B1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF8F98D198]
       mov       r15,rax
       mov       rcx,1CCA8C00CA0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF8F98D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F98BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F98D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F98D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F98D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF8F98D600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F765750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF8F7CB288]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L19
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M01_L20
M01_L19:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      qword ptr [7FFF8F7CB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       lea       ecx,[rbp+2]
       cmp       ecx,1
       ja        near ptr M01_L23
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       near ptr M01_L03
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M01_L04
M01_L21:
       sub       ebx,r12d
       jo        near ptr M01_L26
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF8F7CB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L24
M01_L22:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF8F7CB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF8F7CB288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,1CCA0C08A90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L25:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L26:
       call      CORINFO_HELP_OVERFLOW
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFF8F98D498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FFF8F7D6C58
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF8F98BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF8F98D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF8F98D600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF8F98D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF8F79D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFF8F384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F79D960]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2063
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1CCA0C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FFF8F384000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF8F384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F5FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF8F765750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

