## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C355D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,26EE0A81C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,26EA0A81568
       mov       r14,[rdx]
       mov       rdx,26EE0A81C30
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,994
       mov       rdx,7FF948DD1370
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DD1370
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
       mov       rax,26EA0A83020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948914000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948914000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9AB439318]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9AAF27B00]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9AB439438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9AB0FD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,17C6C4125B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,17C6C402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,17C6C402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,17C70400C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF9AAF3B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,17C6C400528
       mov       r14,[rdx]
       mov       rdx,17C70400C88
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FF9AAED3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FF9AAF3B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AB0FD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,17C70400C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,17C6C402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,17C6C402028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AACB1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9AAF3B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
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
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,17C6C402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACDD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAED5750]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,1F330C048F8
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1F330BF1568
       mov       r14,[rdx]
       mov       rdx,1F330C04900
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,994
       mov       rdx,7FF948DB1370
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rax,1F330BF3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9AB405B88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9AAEF7B00]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9AB405CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9AB0CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,13BBB0125B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,13BBB002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,13BBB002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,13BB7000C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF9AAF0B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,13BBB000528
       mov       r14,[rdx]
       mov       rdx,13BB7000C88
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FF9AAEA3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FF9AAF0B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AB0CD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,13BB7000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,13BBB002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,13BBB002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AAC81C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9AAF0B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF9AB0CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA1C78]
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
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,13BBB002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA34000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACAD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA5750]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,22FA3631C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,22FC3631568
       mov       r14,[rdx]
       mov       rdx,22FA3631C30
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,994
       mov       rdx,7FF948DB1370
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rax,22FC3633020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9AB417888]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9AAF07B00]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9AB4179A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,244F10125B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,244F1002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,244F1002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,244FB000C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF9AAF1B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,244F1000528
       mov       r14,[rdx]
       mov       rdx,244FB000C88
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FF9AAEB3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FF9AAF1B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,244FB000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,244F1002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,244F1002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AAC91C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9AAF1B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
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
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,244F1002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACBD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB5750]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,2C86B791C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2C80B791568
       mov       r14,[rdx]
       mov       rdx,2C86B791C30
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,994
       mov       rdx,7FF948DB1370
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rax,2C80B793020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9ABA07888]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9AB4F7B00]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ABA079A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9AB6CD378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,1C0840125B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9AB2C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,1C084002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C084002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,1C08E000C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF9AB50B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,1C084000528
       mov       r14,[rdx]
       mov       rdx,1C08E000C88
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FF9AB4A3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FF9AB50B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AB6CD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,1C08E000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,1C084002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1C084002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AB281C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB6CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9AB50B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB4A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB4A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF9AB6CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB4A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB4A1C78]
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
       call      qword ptr [7FF9AB2C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C084002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AB034000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AB034000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AB2AD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AB4A5750]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,1FFEDF31C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1FF8DF31568
       mov       r14,[rdx]
       mov       rdx,1FFEDF31C30
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,994
       mov       rdx,7FF948DB1370
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rax,1FF8DF33020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF988767018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF988257B00]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF988767138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF98842D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,1B054C125B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,1B054C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B054C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,1B054C13950
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF98826B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,1B054C00528
       mov       r14,[rdx]
       mov       rdx,1B054C13958
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FF988203FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FF98826B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF98842D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,1B054C13948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,1B054C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1B054C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FE1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF98826B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
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
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B054C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98800D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF988205750]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C055D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,27454961C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,27474961568
       mov       r14,[rdx]
       mov       rdx,27454961C30
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,994
       mov       rdx,7FF948DA1370
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DA1370
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
       mov       rax,27474963020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488E4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF988757018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF988247B00]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF988757138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF98841D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,1E0AF4125B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,1E0AF402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E0AF402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,1E0AF413950
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF98825B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,1E0AF400528
       mov       r14,[rdx]
       mov       rdx,1E0AF413958
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FF9881F3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FF98825B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF98841D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,1E0AF413948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,1E0AF402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1E0AF402028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FD1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF98825B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
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
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E0AF402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF987FFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9881F5750]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C055D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,1B51BB31C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1B4ABB31568
       mov       r14,[rdx]
       mov       rdx,1B51BB31C30
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,994
       mov       rdx,7FF948DA1370
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DA1370
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
       mov       rax,1B4ABB33020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488E4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF988757318]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF988247B00]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF988757438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF98841D378]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,2404100E1B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,24045002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24045002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,2404D000C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF98825B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,24045000528
       mov       r14,[rdx]
       mov       rdx,2404D000C88
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FF9881F3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FF98825B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF98841D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,2404D000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,24045002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,24045002028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FD1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF98825B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
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
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24045002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF987FFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9881F5750]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1D859573B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF948C255D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DC1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DC1370
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
       mov       rdx,7FF948DC1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DC1370
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
       mov       rax,1D859563020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948904000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948904000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,1183AC12B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB4378D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9AAF27B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0FD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,1184AC00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,1183AC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1183AC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FF9AB0FD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1184AC00C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,1183AC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1183AC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AACB1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FF9AB437870]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9AB4379D8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
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
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1183AC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACDD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAED5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,26AB1D83B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF948C255D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DC1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DC1370
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
       mov       rdx,7FF948DC1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DC1370
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
       mov       rax,26AB1D73020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948904000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948904000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,16E82812B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB419360]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9AAF07B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,16E8C800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,16E82802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,16E82802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,16E8C800C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,16E82802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,16E82802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AAC91C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FF9AB419300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9AB419468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
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
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,16E82802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACBD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1FEF3593B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DB1370
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
       mov       rax,1FEF3583020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,15E1E012B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB417BD0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9AAF07B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,15E2E000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,15E1E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,15E1E002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,15E2E000C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,15E1E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,15E1E002028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AAC91C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FF9AB417B70]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9AB417CD8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
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
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,15E1E002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACBD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1CABA701B68
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF948C055D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DA1370
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DA1370
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
       mov       rax,1CABA6F1028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488E4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,2C2BFC12B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB9F9060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9AB4E7B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB6BD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,2C2BDC00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,2C2BFC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,2C2BFC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FF9AB6BD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,2C2BDC00C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9AB2B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,2C2BFC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2C2BFC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AB271C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB6BD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB511640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB511640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6BD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB273510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FF9AB9F9000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9AB9F9168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9AB491C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB491C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FF9AB6BD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB511640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB511640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6BBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6BD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6BD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB273510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6BD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4BD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB491C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB491C78]
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
       call      qword ptr [7FF9AB2B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C2BFC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AB024000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AB024000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AB29D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AB495750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1508ECE3B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DB1370
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
       mov       rax,1508ECD3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,22AE0412B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF988757360]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF988247B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98841D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,22AE8400C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,22AE0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,22AE0402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FF98841D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,22AE8400C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,22AE0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,22AE0402028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FD1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FF988757300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF988757468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
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
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22AE0402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF987FFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9881F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1C1F5EA3B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF948C355D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DD1370
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DD1370
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
       mov       rax,1C1F5E93020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948914000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948914000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,1E246812B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF988779360]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF988267B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98843D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,1E24A800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,1E246802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1E246802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FF98843D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1E24A800C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,1E246802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1E246802028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FF1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98843D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98843BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98843D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98843D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98843D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FF988779300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF988779468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF988211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FF98843D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98843BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98843D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98843D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98843D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988211C78]
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
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E246802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987DA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987DA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98801D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF988215750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,21836983B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF948C455D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DE1370
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DE1370
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
       mov       rax,21836973020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948924000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948924000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,28CD0C12B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF988757060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF988247B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98841D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,28CD8C00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,28CD0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,28CD0C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FF98841D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,28CD8C00C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,28CD0C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,28CD0C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FD1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FF988757000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF988757168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
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
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28CD0C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF987FFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9881F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,19EF9463B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF948C455D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DE1370
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FF948DE1370
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DE1370
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
       mov       rax,19EF9453020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948924000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948924000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,29CAF812B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB439348]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9AAF27B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0FD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,29CB1801C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,29CAF802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,29CAF802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FF9AB0FD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,29CB1801C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,29CAF802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,29CAF802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AACB1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FF9AB0FD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,29CB1801CA0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,29CAF802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,29CAF802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AACB1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FF9AB439300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9AB439480]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
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
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
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
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29CAF802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACDD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAED5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,210E5883B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF948C455D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DE1370
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FF948DE1370
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DE1370
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
       mov       rax,210E5873020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948924000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948924000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,23F93C12B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB415BB8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9AAF07B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,23F95C01C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,23F93C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,23F93C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,23F95C01C98
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,23F93C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,23F93C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AAC91C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,23F95C01CA0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,23F93C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,23F93C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AAC91C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FF9AB415B70]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9AB415CF0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
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
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
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
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23F93C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACBD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,10E551F3B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF948C055D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DA1370
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FF948DA1370
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DA1370
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
       mov       rax,10E551E3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488E4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,2388E812B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB407348]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9AAEF7B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0CD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,23892800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,2388E802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,2388E802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FF9AB0CD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,23892800C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,2388E802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2388E802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AAC81C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FF9AB0CD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,23892800C88
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,2388E802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2388E802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AAC81C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB0CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FF9AB407300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9AB407480]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9AAEA1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FF9AB0CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF21640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC83510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAECD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA1C78]
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
       call      qword ptr [7FF9AAEA1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA1C78]
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
       call      qword ptr [7FF9AACC99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2388E802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA34000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACAD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAEA5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,182DAE73B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF948C455D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DE1370
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FF948DE1370
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DE1370
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
       mov       rax,182DAE63020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948924000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948924000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,2176C8006A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB9E78B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9AB4D7B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB6AD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,2176C801490
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2A99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,21770802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2A99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,21770802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FF9AB6AD378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,2176C801498
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FF9AB2A99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,21770802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2A99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,21770802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AB261C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB6AD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB501640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB501640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6AD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FF9AB6AD378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,2176C8014A0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9AB2A99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,21770802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2A99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,21770802028
       mov       rdx,[rdx]
       call      qword ptr [7FF9AB261C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF9AB6AD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB501640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB501640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6AD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FF9AB9E7870]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9AB9E79F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9AB481C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB481C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FF9AB6AD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB501640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB501640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6ABC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6AD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6AD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4AD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6AD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4AD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB481C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB481C78]
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
       call      qword ptr [7FF9AB481C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB481C78]
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
       call      qword ptr [7FF9AB2A99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21770802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AB014000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AB014000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AB28D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AB485750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1632FC23B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF948C355D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DD1370
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FF948DD1370
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DD1370
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
       mov       rax,1632FC13020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948914000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948914000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,21DDBC12B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF988757348]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF988247B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98841D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,21DE7C00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,21DDBC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,21DDBC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FF98841D378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,21DE7C00C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,21DDBC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,21DDBC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FD1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FF98841D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,21DE7C00C88
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,21DDBC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,21DDBC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FD1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FF988757300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF988757480]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
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
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
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
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21DDBC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF987FFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9881F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,19057D53B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FF948DB1370
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DB1370
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
       mov       rax,19057D43020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,1E7F0412B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF988779048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF988267B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98843D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,1E7FA400C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,1E7F0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1E7F0402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FF98843D378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,1E7FA400C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,1E7F0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1E7F0402028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FF1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98843D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98843BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98843D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98843D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98843D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FF98843D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,1E7FA400C88
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,1E7F0402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1E7F0402028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FF1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98843D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98843BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98843D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98843D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98843D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FF988779000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF988779180]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF988211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FF98843D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988291640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98843BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98843D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98843D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98843D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98823D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988211C78]
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
       call      qword ptr [7FF988211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988211C78]
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
       call      qword ptr [7FF9880399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E7F0402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987DA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987DA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98801D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF988215750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1CAC8273B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF948C355D0]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DD1370
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FF948DD1370
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9EA
       mov       rdx,7FF948DD1370
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
       mov       rax,1CAC8263020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948914000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948914000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rdx,28A068006A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9887678B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF988257B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98842D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,28A16800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,28A0A802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,28A0A802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FF98842D378]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,28A16800C80
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,28A0A802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,28A0A802028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FE1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FF98842D378]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,28A16800C88
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,28A0A802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,28A0A802028
       mov       rdx,[rdx]
       call      qword ptr [7FF987FE1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FF988767870]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       call      qword ptr [7FF9887679F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
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
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
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
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28A0A802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98800D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF988205750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,211B51E3020
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
       mov       rcx,7FF948C408D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,211B51EDA68
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,211A51E1C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,211B51E1568
       mov       r15,[rdx]
       mov       rdx,211A51E1C30
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
       call      qword ptr [7FF948C255D0]; System.Text.StringBuilder.ToString()
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
       mov       rcx,211B51EDA68
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
       mov       rcx,7FF948C408D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,211B51EDA68
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9AB419000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9AB4190D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1DD11802028
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
       mov       rcx,1DD1180CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB2D2010]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1DD11813948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9AAF1B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1DD11800528
       mov       r12,[rdx]
       mov       rdx,1DD11813950
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9AAEB3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9AAF1B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AAF07B00]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9AAF1B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9AB2D2018]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1DD1180CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9AB2D2018]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,231D51C3020
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
       mov       rcx,7FF948C608D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,231D51CDA68
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,232651C1C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,231D51C1568
       mov       r15,[rdx]
       mov       rdx,232651C1C30
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
       call      qword ptr [7FF948C455D0]; System.Text.StringBuilder.ToString()
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
       mov       rcx,231D51CDA68
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
       mov       rcx,7FF948C608D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,231D51CDA68
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9AB449000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9AB4490D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,22390002028
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
       mov       rcx,2239000CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB2CE588]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,22390014960
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9AAF4B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,22390000528
       mov       r12,[rdx]
       mov       rdx,22390014968
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9AAEE3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9AAF4B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AAF37B00]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9AAF4B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9AB2CE590]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2239000CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9AB2CE590]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,22ACBE93020
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
       mov       rcx,7FF948C308D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22ACBE9DA68
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,22AEBE91C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,22ACBE91568
       mov       r15,[rdx]
       mov       rdx,22AEBE91C30
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rcx,22ACBE9DA68
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
       mov       rcx,7FF948C308D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22ACBE9DA68
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9AB417870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9AB417948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,23BA5002028
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
       mov       rcx,23BA500CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB2D09F0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,23BAF000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9AAF1B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,23BA5000528
       mov       r12,[rdx]
       mov       rdx,23BAF000C80
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9AAEB3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9AAF1B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AAF07B00]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9AAF1B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9AB2D09F8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,23BA500CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9AB2D09F8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,1DCD33F3020
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
       mov       rcx,7FF948C608D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DCD33FDA68
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1DD333F1C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1DCD33F1568
       mov       r15,[rdx]
       mov       rdx,1DD333F1C30
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
       call      qword ptr [7FF948C455D0]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1DCD33FDA68
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
       mov       rcx,7FF948C608D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DCD33FDA68
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9ABA07300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9ABA073D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,24AB3802028
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
       mov       rcx,24AB380CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9AB88D690]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,24ABF800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9AB50B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,24AB3800528
       mov       r12,[rdx]
       mov       rdx,24ABF800C80
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9AB4A3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9AB50B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AB4F7B00]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9AB50B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9AB88D698]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,24AB380CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9AB88D698]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,29458AC3020
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
       mov       rcx,7FF948C308D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29458ACDA68
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,29448AC1C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,29458AC1568
       mov       r15,[rdx]
       mov       rdx,29448AC1C30
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rcx,29458ACDA68
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
       mov       rcx,7FF948C308D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29458ACDA68
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF988787000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9887870D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,295AA002028
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
       mov       rcx,295AA00CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF98860D690]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,295B4000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF98828B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,295AA000528
       mov       r12,[rdx]
       mov       rdx,295B4000C80
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF988223FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF98828B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF988277B00]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF98828B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF98860D698]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,295AA00CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF98860D698]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,191D5863020
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
       mov       rcx,7FF948C308D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,191D586DA68
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,19225861C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,191D5861568
       mov       r15,[rdx]
       mov       rdx,19225861C30
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       rcx,191D586DA68
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
       mov       rcx,7FF948C308D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,191D586DA68
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF988747300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9887473D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1CFF6402028
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
       mov       rcx,1CFF640CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF988601350]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1CFF6413948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF98824B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1CFF6400528
       mov       r12,[rdx]
       mov       rdx,1CFF6413950
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9881E3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF98824B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF988237B00]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF98824B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF988601358]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1CFF640CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF988601358]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,16BD10F3020
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
       mov       rcx,7FF948C508D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16BD10FDA68
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,16C310F1C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,16BD10F1568
       mov       r15,[rdx]
       mov       rdx,16C310F1C30
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
       call      qword ptr [7FF948C355D0]; System.Text.StringBuilder.ToString()
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
       mov       rcx,16BD10FDA68
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
       mov       rcx,7FF948C508D0
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16BD10FDA68
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF988767300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9887673D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,257BE402028
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
       mov       rcx,257BE40CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9885EF920]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,257C4401C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF98826B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,257BE400528
       mov       r12,[rdx]
       mov       rdx,257C4401C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF988203FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF98826B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF988257B00]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF98826B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9885EF928]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,257BE40CAC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9885EF928]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       ecx,215
       mov       rdx,7FF948DB1370
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
       mov       ecx,21D
       mov       rdx,7FF948DB1370
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
       mov       ecx,9B4
       mov       rdx,7FF948DB1370
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
       mov       ecx,9D0
       mov       rdx,7FF948DB1370
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
       mov       rcx,7FF948DB1B20
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,1D2043DE360
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
       mov       rdx,1D2043E3B60
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rax,1D2043D3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9AB4378A0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9AAF27B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0FD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1964F000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,19645002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19645002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FF9AAF3B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,1964500D5E8
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF9AACB3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF9AAF3B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9AAF3B3C0]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF9AB0FD498]
       mov       rbx,rax
       mov       ecx,215
       mov       rdx,7FF9AB0B5160
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FF9AAF3B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF9AB0FD498]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FF9AB0B5160
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF9AAB88D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF9AB0FD198]
       mov       r12,rax
       mov       rcx,1964F000C80
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAED5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FF9AAB91708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9AB0FD198]
       mov       r15,rax
       mov       rcx,1964F000C88
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAED5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9AAF3B288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF9AAF3B258]; System.Text.StringBuilder.Append(Char, Int32)
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
       call      qword ptr [7FF9AAF3B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9AAF3B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9AAF3B288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,19645012B58
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9AAF3B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FF9AB0FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF51640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEFD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AAEFD960]
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
       call      qword ptr [7FF9AACF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19645002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACDD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAED5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C055D0]; System.Text.StringBuilder.ToString()
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
       mov       ecx,215
       mov       rdx,7FF948DA1370
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
       mov       ecx,21D
       mov       rdx,7FF948DA1370
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
       mov       ecx,9B4
       mov       rdx,7FF948DA1370
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
       mov       ecx,9D0
       mov       rdx,7FF948DA1370
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
       mov       rcx,7FF948DA1B20
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,2A9B9FD9F58
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
       mov       rdx,2A999FD5AB0
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
       mov       rdx,7FF948DA1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DA1370
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
       mov       rax,2A999FD3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488E4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9AB4178A0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9AAF07B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0DD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,29F4D800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,29F43802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29F43802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FF9AAF1B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,29F4380D5E8
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF9AAC93660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF9AAF1B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9AAF1B3C0]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF9AB0DD498]
       mov       rbx,rax
       mov       ecx,215
       mov       rdx,7FF9AB095160
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FF9AAF1B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF9AB0DD498]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FF9AB095160
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF9AAB68D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF9AB0DD198]
       mov       r12,rax
       mov       rcx,29F4D800C80
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEB5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FF9AAB71708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9AB0DD198]
       mov       r15,rax
       mov       rcx,29F4D800C88
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEB5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9AAF1B288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF9AAF1B258]; System.Text.StringBuilder.Append(Char, Int32)
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
       call      qword ptr [7FF9AAF1B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9AAF1B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9AAF1B288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,29F43812B58
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9AAF1B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FF9AB0DD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF31640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0DD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AAC93510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEDD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AAEDD960]
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
       call      qword ptr [7FF9AACD99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29F43802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACBD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAEB5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C455D0]; System.Text.StringBuilder.ToString()
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
       mov       ecx,215
       mov       rdx,7FF948DE1370
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
       mov       ecx,21D
       mov       rdx,7FF948DE1370
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
       mov       ecx,9B4
       mov       rdx,7FF948DE1370
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
       mov       ecx,9D0
       mov       rdx,7FF948DE1370
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
       mov       rcx,7FF948DE1B20
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,220D3E7E360
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
       mov       rdx,220D3E83B60
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
       mov       rdx,7FF948DE1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DE1370
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
       mov       rax,220D3E73020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948924000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948924000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9AB427030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9AAF17B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB0ED378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1F911813948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,1F911802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AACE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F911802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FF9AAF2B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,1F91180D5E8
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF9AACA3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF9AAF2B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9AAF2B3C0]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF9AB0ED498]
       mov       rbx,rax
       mov       ecx,215
       mov       rdx,7FF9AB0A5160
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9AB0ED078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9AB0ED558]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF9AAEED8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FF9AAF2B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF9AB0ED498]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FF9AB0A5160
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,340
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0ED078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9AB0ED558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF9AAB78D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF9AB0ED198]
       mov       r12,rax
       mov       rcx,1F911813950
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FF9AB0ED498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0ED558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FF9AACA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0ED090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9AB0ED558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEC5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FF9AAB81708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9AB0ED198]
       mov       r15,rax
       mov       rcx,1F911813958
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FF9AB0ED498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0ED558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FF9AACA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0ED090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9AB0ED558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEC5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9AAF2B288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF9AAF2B258]; System.Text.StringBuilder.Append(Char, Int32)
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
       call      qword ptr [7FF9AAF2B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9AAF2B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9AAF2B288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,1F911812B58
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9AAF2B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AAEC1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AAEC1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FF9AB0ED498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AAF41640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB0EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB0ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB0ED558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AAEED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AACA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB0ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AAEED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FF9AAA54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AAEED960]
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
       call      qword ptr [7FF9AACE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F911802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AAA54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AAA54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AACCD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AAEC5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       ecx,215
       mov       rdx,7FF948DB1370
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
       mov       ecx,21D
       mov       rdx,7FF948DB1370
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
       mov       ecx,9B4
       mov       rdx,7FF948DB1370
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
       mov       ecx,9D0
       mov       rdx,7FF948DB1370
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
       mov       rcx,7FF948DB1B20
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,205E94B9F58
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
       mov       rdx,205E94BF758
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rax,206294B3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9ABA09030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9AB4F7B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9AB6CD378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1FBE0C00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,1FBDCC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9AB2C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FBDCC02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FF9AB50B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,1FBDCC0D5E8
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF9AB283660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF9AB50B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9AB50B3C0]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF9AB6CD498]
       mov       rbx,rax
       mov       ecx,215
       mov       rdx,7FF9AB685160
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9AB6CD078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FF9AB50B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF9AB6CD498]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FF9AB685160
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,340
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6CD078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF9AB158D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF9AB6CD198]
       mov       r12,rax
       mov       rcx,1FBE0C00C80
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FF9AB6CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FF9AB283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6CD090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FF9AB161708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF9AB6CD198]
       mov       r15,rax
       mov       rcx,1FBE0C00C88
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FF9AB6CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FF9AB283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6CD090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9AB50B288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF9AB50B258]; System.Text.StringBuilder.Append(Char, Int32)
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
       call      qword ptr [7FF9AB50B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9AB50B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9AB50B288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,1FBDCC12B58
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9AB50B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9AB4A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB4A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FF9AB6CD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF9AB521640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9AB6CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9AB6CD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9AB6CD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF9AB283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9AB6CD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9AB4CD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FF9AB034000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AB4CD960]
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
       call      qword ptr [7FF9AB2C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FBDCC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9AB034000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9AB034000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9AB2AD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9AB4A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C255D0]; System.Text.StringBuilder.ToString()
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
       mov       ecx,215
       mov       rdx,7FF948DC1370
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
       mov       ecx,21D
       mov       rdx,7FF948DC1370
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
       mov       ecx,9B4
       mov       rdx,7FF948DC1370
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
       mov       ecx,9D0
       mov       rdx,7FF948DC1370
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
       mov       rcx,7FF948DC1B20
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,2A6B214E360
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
       mov       rdx,2A6B2153B60
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
       mov       rdx,7FF948DC1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DC1370
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
       mov       rax,2A6B2143020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948904000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948904000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF988769330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF988257B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98842D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,2486EC00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,24864C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24864C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FF98826B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,24864C0D5E8
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF987FE3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF98826B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF98826B3C0]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF98842D498]
       mov       rbx,rax
       mov       ecx,215
       mov       rdx,7FF9883E5160
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FF98826B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF98842D498]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FF9883E5160
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF987EB8D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF98842D198]
       mov       r12,rax
       mov       rcx,2486EC00C80
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF988205750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FF987EC1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF98842D198]
       mov       r15,rax
       mov       rcx,2486EC00C88
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF988205750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF98826B288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF98826B258]; System.Text.StringBuilder.Append(Char, Int32)
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
       call      qword ptr [7FF98826B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF98826B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF98826B288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,24864C12B58
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF98826B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98822D960]
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
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24864C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98800D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF988205750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C155D0]; System.Text.StringBuilder.ToString()
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
       mov       ecx,215
       mov       rdx,7FF948DB1370
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
       mov       ecx,21D
       mov       rdx,7FF948DB1370
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
       mov       ecx,9B4
       mov       rdx,7FF948DB1370
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
       mov       ecx,9D0
       mov       rdx,7FF948DB1370
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
       mov       rcx,7FF948DB1B20
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,2794E8DE360
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
       mov       rdx,2794E8E3B60
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
       mov       rdx,7FF948DB1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DB1370
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
       mov       rax,2794E8D3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9488F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9488F4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF988767030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF988257B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98842D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,20AD8000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,20AD4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20AD4002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FF98826B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,20AD400D5E8
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF987FE3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF98826B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF98826B3C0]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF98842D498]
       mov       rbx,rax
       mov       ecx,215
       mov       rdx,7FF9883E5160
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FF98826B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF98842D498]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FF9883E5160
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF987EB8D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF98842D198]
       mov       r12,rax
       mov       rcx,20AD8000C80
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF988205750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FF987EC1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF98842D198]
       mov       r15,rax
       mov       rcx,20AD8000C88
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF988205750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF98826B288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF98826B258]; System.Text.StringBuilder.Append(Char, Int32)
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
       call      qword ptr [7FF98826B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF98826B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF98826B288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,20AD4012B58
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF98826B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF988201C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FF98842D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988281640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98842BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98842D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98842D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98842D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98822D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98822D960]
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
       call      qword ptr [7FF9880299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20AD4002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98800D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF988205750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FF948C355D0]; System.Text.StringBuilder.ToString()
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
       mov       ecx,215
       mov       rdx,7FF948DD1370
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
       mov       ecx,21D
       mov       rdx,7FF948DD1370
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
       mov       ecx,9B4
       mov       rdx,7FF948DD1370
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
       mov       ecx,9D0
       mov       rdx,7FF948DD1370
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
       mov       rcx,7FF948DD1B20
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L12:
       mov       r9,1AD5BE69F58
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
       mov       rdx,1AD5BE6F758
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
       mov       rdx,7FF948DD1370
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9A0
       mov       rdx,7FF948DD1370
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
       mov       rax,1AD7BE63020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF948914000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF948914000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FF988757030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF988247B00]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF98841D378]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,26ACF413948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+10]
       mov       rdx,26ACF402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26ACF402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FF98825B258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,26ACF40D5E8
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF987FD3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L21
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L26
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FF98825B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF98825B3C0]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF98841D498]
       mov       rbx,rax
       mov       ecx,215
       mov       rdx,7FF9883D5160
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FF98825B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF98841D498]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FF9883D5160
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbp
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FF987EA8D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FF98841D198]
       mov       r12,rax
       mov       rcx,26ACF413950
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9881F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FF987EB1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FF98841D198]
       mov       r15,rax
       mov       rcx,26ACF413958
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9881F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF98825B288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF98825B258]; System.Text.StringBuilder.Append(Char, Int32)
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
       call      qword ptr [7FF98825B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF98825B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF98825B288]; System.Text.StringBuilder.Append(System.String)
M01_L24:
       lea       edx,[r14+2]
       cmp       edx,1
       ja        short M01_L25
       mov       rdx,26ACF412B58
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF98825B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9881F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FF98841D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FF988271640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF98841BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF98841D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF98841D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF987FD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF98841D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF98821D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF98821D960]
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
       call      qword ptr [7FF9880199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26ACF402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF987D84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF987FFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9881F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

