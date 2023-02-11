## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,227030968C0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,22703091568
       mov       r14,[rdx]
       mov       rdx,227030968C8
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DE02950
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE02950
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
       mov       rax,22703093020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9D4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7B66B018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B1ECF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B3ABD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,264C48040D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,264C8802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,264C8802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,264C48054D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,264C8800528
       mov       r14,[rdx]
       mov       rdx,264C48054E0
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B1A3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B3ABD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,264C48054D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,264C8802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,264C8802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B011C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B3ABEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B216888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B216888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B3AB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B3ABAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B3AD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B17FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B3ABAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B17FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B20B258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B1A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B1A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B3ABEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B216888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B216888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B3AB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B3ABAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B3AD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B17FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B3ABAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B17FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B1A1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B1A1C78]
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
       call      qword ptr [7FFF7B0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,264C8802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7ADC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7ADC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B03D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B1A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,277621B88A0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,277A21B1568
       mov       r14,[rdx]
       mov       rdx,277621B88A8
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DE02950
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE02950
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
       mov       rax,277621B1028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9D4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC1B318]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B79CF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,28B6B400100
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,28B6F402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28B6F402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,28B6B401500
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,28B6F400528
       mov       r14,[rdx]
       mov       rdx,28B6B401508
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B753FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,28B6B4014F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,28B6F402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,28B6F402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7BB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
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
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28B6F402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC59E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,2DE5A8F2CB8
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2DE9A8F1568
       mov       r14,[rdx]
       mov       rdx,2DE5A8F2CC0
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
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DDF2950
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
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DDF2950
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
       mov       rax,2DE7A8F1028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9C4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC2B318]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7ACF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,21AFA8040D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,21AFE802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21AFE802028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,21AFA8054D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,21AFE800528
       mov       r14,[rdx]
       mov       rdx,21AFA8054E0
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B763FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,21AFA8054D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,21AFE802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,21AFE802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7CB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
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
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21AFE802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B765750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,2ABB2BF6490
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2ABD2BF1568
       mov       r14,[rdx]
       mov       rdx,2ABB2BF6498
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rax,2ABD2BF3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC2B018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7ACF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,2223D4040D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,22249402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22249402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,22241401D00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,22249400528
       mov       r14,[rdx]
       mov       rdx,22241401D08
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B763FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,22241401CF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,22249402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,22249402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7CB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
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
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22249402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B765750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,2281DF6A898
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2281DF61568
       mov       r14,[rdx]
       mov       rdx,2281DF6A8A0
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rax,2281DF63020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BA0B318]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B58CF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B74BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,1B2DDC084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B3F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,1B2DDC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B3F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B2DDC02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,1B2DDC098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B5AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,1B2DDC00528
       mov       r14,[rdx]
       mov       rdx,1B2DDC098E8
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B543FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B5AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B74BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,1B2DDC098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B3F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,1B2DDC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B3F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1B2DDC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B3B1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B74BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5B6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5B6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B74B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B74BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B74D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B51FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B74BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B51FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B5AB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B541C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B541C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B74BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5B6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5B6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B74B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B74BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B74D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B51FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B74BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B51FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B541C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B541C78]
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
       call      qword ptr [7FFF7B3F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B2DDC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B164000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B164000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B3DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B545750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,2240BD3B8B0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2240BD31568
       mov       r14,[rdx]
       mov       rdx,2240BD3B8B8
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
       mov       rax,2240BD33020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BA1B318]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B59CF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B75BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,27A394084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B4099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,27A39402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27A39402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,27A394098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B5BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,27A39400528
       mov       r14,[rdx]
       mov       rdx,27A394098E8
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B553FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B5BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B75BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,27A394098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,27A39402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,27A39402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B3C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B75BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B75B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B75BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B75D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B52FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B75BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B52FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B5BB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B551C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B551C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B75BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B75B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B75BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B75D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B52FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B75BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B52FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B551C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B551C78]
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
       call      qword ptr [7FFF7B4099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27A39402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B174000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B174000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B3ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B555750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC99E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,23304512CB8
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,232C4511568
       mov       r14,[rdx]
       mov       rdx,23304512CC0
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DE32950
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE32950
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
       mov       rax,232C4513020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7DA04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7DA04000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC2B018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7ACF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,293904084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,29390402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29390402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,293904098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,29390400528
       mov       r14,[rdx]
       mov       rdx,293904098E8
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B763FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,293904098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,29390402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,29390402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7CB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
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
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29390402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B765750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,25DC6C5A898
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,25DC6C51568
       mov       r14,[rdx]
       mov       rdx,25DC6C5A8A0
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rax,25DC6C53020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC1B018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B79CF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,2268D4084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,2268D402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2268D402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,2268D4098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,2268D400528
       mov       r14,[rdx]
       mov       rdx,2268D4098E8
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B753FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,2268D4098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,2268D402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2268D402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7BB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
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
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2268D402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC99E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
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
       mov       rdx,207D6DC94A0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,207D6DC1568
       mov       r14,[rdx]
       mov       rdx,207D6DC94A8
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,95A
       mov       rdx,7FFF7DE32950
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE32950
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
       mov       rax,20816DC1028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7DA04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7DA04000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC3B018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L13
       lea       rcx,[rbx+0C]
       mov       rdx,1A581C084E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L14
       lea       rcx,[rbx+16]
       mov       rdx,1A581C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A581C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rdx,1A581C0A8F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF7B7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L06
       mov       rdx,1A581C00528
       mov       r14,[rdx]
       mov       rdx,1A581C0A900
       mov       r15,[rdx]
M01_L04:
       mov       edx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      qword ptr [7FFF7B773FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFF7B7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],2
       jl        near ptr M01_L17
       lea       rcx,[rsi+0C]
       mov       rdx,1A581C0A8F0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rsi+10]
       mov       rdx,1A581C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1A581C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]
       jmp       near ptr M01_L07
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
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
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A581C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,1C638209A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE22950
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
       mov       rax,1C638203020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,19B9CC08A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B64B360]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B1CCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B38BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,19B9CC098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,19B9CC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,19B9CC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B38BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,19B9CC098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,19B9CC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,19B9CC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7AFF1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B38BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B1F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B1F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B38B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B38BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B38D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B15FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7AFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B38BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B15FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7B64B300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7B64A420
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7B64B468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B181C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B181C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B38BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B1F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B1F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B38B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B38BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B38D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B15FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7AFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B38BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B15FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B181C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B181C78]
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
       call      qword ptr [7FFF7B0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19B9CC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7ADA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7ADA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B01D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B185750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,181E9B79A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE12950
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
       mov       rax,181E9B73020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,1E62C804640
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC5B060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7DCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,1E62C8054D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,1E630802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1E630802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1E62C8054D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,1E630802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1E630802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B601C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC5B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC5A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC5B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
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
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E630802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,23C62645630
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC99E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE32950
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE32950
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
       mov       rax,23C82643020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7DA04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7DA04000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,2B5A9C06A50
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC2B060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7ACF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,2B5A9C078E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,2B5A9C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,2B5A9C00030
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,2B5A9C078E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,2B5A9C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2B5A9C00030
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC2B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC2A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC2B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
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
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B5A9C00030
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B765750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,161C2BC9A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE12950
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
       mov       rax,161C2BC3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,16FA0000668
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC3B060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,16FA00014F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,16FA4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,16FA4002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,16FA0001500
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,16FA4002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,16FA4002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC3B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC3A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC3B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
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
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,16FA4002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,223B5859A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE22950
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
       mov       rax,223B5853020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,22343404640
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BA3B060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B5BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B77BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,223434054D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,22347402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,22347402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B77BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,223434054D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B4299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,22347402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,22347402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B3E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B77BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B77B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B77BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B77D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B54FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B77BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B54FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7BA3B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BA3A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BA3B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B571C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B571C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B77BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B77B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B77BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B77D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B54FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B77BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B54FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B571C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B571C78]
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
       call      qword ptr [7FFF7B4299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22347402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B194000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B194000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B40D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B575750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,2DB2D1F1658
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE22950
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
       mov       rax,2DB0D1F3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,1C8CB408A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC1B060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B79CF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,1C8C9400CE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,1C8CB402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1C8CB402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1C8C9400CE8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,1C8CB402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1C8CB402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC1B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC1A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC1B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
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
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C8CB402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,217A1CA7A40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE02950
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE02950
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
       mov       rax,217A1CA1028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9D4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,191AA008A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC5B060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7DCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,191AA0098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,191AA002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,191AA002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,191AA0098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,191AA002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,191AA002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B601C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC5B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC5A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC5B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
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
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,191AA002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,259A3099A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE22950
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
       mov       rax,259A3093020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,1FD4A800668
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC4B060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7CCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B98BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,1FD4A8014F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,1FD4E802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1FD4E802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B98BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1FD4A801500
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,1FD4E802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1FD4E802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5F1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B98BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC4B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC4A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC4B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B98BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
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
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FD4E802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,24C03949A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7DC99E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE32950
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE32950
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
       mov       rax,24C03943020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7DA04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7DA04000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,2CBE7C08A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC3B060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FFF7B7BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,2CBE7C098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+10]
       mov       rdx,2CBE7C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,2CBE7C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L11
       lea       rcx,[rdi+0C]
       mov       rdx,2CBE7C098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[rdi+18]
       mov       rdx,2CBE7C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2CBE7C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC3B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC3A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC3B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
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
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2CBE7C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,1D605945630
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE12950
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
       mov       rax,1D625943020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,2523AC00668
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B63B048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B1BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B37BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,2523AC014F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,2523EC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,2523EC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B37BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,2523AC01500
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B0299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,2523EC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2523EC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7AFE1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B37BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B1E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B1E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B37B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B37BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B37D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B14FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7AFE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B37BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B14FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B37BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,2523AC01508
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B0299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,2523EC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2523EC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7AFE1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B37BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B1E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B1E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B37B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B37BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B37D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B14FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7AFE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B37BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B14FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7B63B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7B63A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7B63B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B171C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B171C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B37BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B1E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B1E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B37B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B37BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B37D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B14FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7AFE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B37BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B14FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B171C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B171C78]
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
       call      qword ptr [7FFF7B171C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B171C78]
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
       call      qword ptr [7FFF7B0299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2523EC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7AD94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7AD94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B00D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B175750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,19CAE749A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE22950
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
       mov       rax,19CAE743020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,1A3E6C08A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC5B048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B7DCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,1A3E6C098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,1A3E6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1A3E6C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,1A3E6C098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,1A3E6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,1A3E6C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B601C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,1A3E6C098E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,1A3E6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,1A3E6C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B601C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC5B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC5A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC5B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
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
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
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
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A3E6C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,215199F5630
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC99E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE32950
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DE32950
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
       mov       rdx,7FFF7DE32950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE32950
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
       mov       rax,215399F3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7DA04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7DA04000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,229F8C04640
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC5B048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B7DCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,229F0C00CE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,229F4C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,229F4C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,229F0C00CE8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,229F4C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,229F4C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B601C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,229F0C00CF0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,229F4C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,229F4C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B601C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC5B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC5A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC5B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
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
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
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
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,229F4C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,14D00F49A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE12950
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
       mov       rax,14D00F43020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,27D0C808A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC1B048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B79CF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,27D0C8098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,27D0C802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,27D0C802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,27D0C8098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,27D0C802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,27D0C802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,27D0C8098E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,27D0C802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,27D0C802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC1B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC1A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC1B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
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
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
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
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27D0C802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,24215457A40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE22950
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
       mov       rax,24215451028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,27E18C00668
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BA2B348]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B5ACF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B76BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,27E18C014F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,27E1CC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,27E1CC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B76BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,27E18C01500
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B4199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,27E1CC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,27E1CC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B3D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B76BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B76B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B76BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B76D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B53FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B76BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B53FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B76BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,27E18C01508
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B4199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,27E1CC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,27E1CC02028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B3D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B76BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B76B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B76BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B76D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B53FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B76BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B53FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7BA2B300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BA2A420
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BA2B468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B561C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B561C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B76BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B76B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B76BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B76D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B53FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B76BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B53FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B561C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B561C78]
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
       call      qword ptr [7FFF7B561C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B561C78]
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
       call      qword ptr [7FFF7B4199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27E1CC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B184000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B184000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B3FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B565750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,294C29A5630
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE02950
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DE02950
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
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE02950
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
       mov       rax,294E29A3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9D4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,2C727808A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC3B048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B7BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,2C7278098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,2C727802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,2C727802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,2C7278098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,2C727802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2C727802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,2C7278098E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,2C727802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2C727802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC3B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC3A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC3B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
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
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
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
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C727802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,1D88E1E5630
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DE22950
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
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE22950
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
       mov       rax,1D8AE1E3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,16BFC408A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC2B348]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B7ACF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,16BFC4098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,16BFC402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,16BFC402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,16BFC4098E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,16BFC402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,16BFC402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,16BFC4098E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,16BFC402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,16BFC402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC2B300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC2A420
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC2B468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
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
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
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
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,16BFC402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B765750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,2018EDE5630
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC59E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DDF2950
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
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DDF2950
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
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DDF2950
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
       mov       rax,201AEDE3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9C4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,269B1004640
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC5B048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B7DCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,269B50050E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,269B5002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,269B5002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,269B50050F0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,269B5002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,269B5002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B601C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,269B50050F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,269B5002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,269B5002028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B601C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC5B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC5A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC5B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
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
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
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
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,269B5002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,2CB92097A40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FFF7DE12950
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
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9B0
       mov       rdx,7FFF7DE12950
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
       mov       rax,2CB92091028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,20FE4404640
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FFF7BC1B048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FFF7B79CF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 142
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
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L10
       lea       rcx,[rbx+0C]
       mov       rdx,20FE44054D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L11
       lea       rcx,[rbx+10]
       mov       rdx,20FE8402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,20FE8402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],9
       jl        near ptr M01_L14
       lea       rcx,[rsi+0C]
       mov       rdx,20FE44054D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,12
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,9
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[rsi+1E]
       mov       rdx,20FE8402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,20FE8402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rdi,rdi
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B95BD80]
       mov       ecx,8
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],6
       jl        near ptr M01_L17
       lea       rcx,[rdi+0C]
       mov       rdx,20FE44054E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0C
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,6
       cmp       ecx,2
       jl        near ptr M01_L18
       lea       rcx,[rdi+18]
       mov       rdx,20FE8402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,20FE8402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7B5C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF7BC1B000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF7BC1A120
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF7BC1B168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7B95BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B95B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B95D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B95BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
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
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
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
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20FE8402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,1E8B7323020
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
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E8B73279A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1E8B732A898
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1E8B7321568
       mov       r15,[rdx]
       mov       rdx,1E8B732A8A0
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
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1E8B73279A0
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
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E8B73279A0
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7B64B000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B64B0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,2009EC02028
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
       mov       rcx,2009EC069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B393578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,2009AC014F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B1EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,2009EC00528
       mov       r12,[rdx]
       mov       rdx,2009AC01500
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B183FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B1EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B1CCF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B1EB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B393580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2009EC069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B393580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,1B24CD23020
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
       mov       rcx,7FFF7DC64E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B24CD279A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1B24CD2B8B0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1B24CD21568
       mov       r15,[rdx]
       mov       rdx,1B24CD2B8B8
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
       call      qword ptr [7FFF7DC59E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1B24CD279A0
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
       mov       rcx,7FFF7DC64E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B24CD279A0
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7BC4B000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BC4B0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1BBA5802028
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
       mov       rcx,1BBA18025A0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B993578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1BBA18054D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1BBA5800528
       mov       r12,[rdx]
       mov       rdx,1BBA18054D8
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B783FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B7CCF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7EB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B993580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1BBA18025A0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B993580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,2915AFB1028
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
       mov       rcx,7FFF7DC74E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2915AFB59A8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,2915AFB90A0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,2917AFB1568
       mov       r15,[rdx]
       mov       rdx,2915AFB90A8
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
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,2915AFB59A8
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
       mov       rcx,7FFF7DC74E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2915AFB59A8
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7BC5B000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BC5B0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,187B4C02028
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
       mov       rcx,187B4C069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B9A3578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,187B0C00CE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,187B4C00528
       mov       r12,[rdx]
       mov       rdx,187B0C00CE8
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B793FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B7DCF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7FB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B9A3580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,187B4C069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B9A3580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,26EB7F73020
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
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26E97F73598
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,26E97F76490
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,26EB7F71568
       mov       r15,[rdx]
       mov       rdx,26E97F76498
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
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,26E97F73598
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
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26E97F73598
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7BC1B300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BC1B3D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,245E7C02028
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
       mov       rcx,245E7C069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B963578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,245E3C014F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,245E7C00528
       mov       r12,[rdx]
       mov       rdx,245E3C01500
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B753FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B79CF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7BB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B963580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,245E7C069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B963580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,21207B53020
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
       mov       rcx,7FFF7DC84E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21207B579A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,21207B5A898
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,21207B51568
       mov       r15,[rdx]
       mov       rdx,21207B5A8A0
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
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,21207B579A0
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
       mov       rcx,7FFF7DC84E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21207B579A0
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7BA2B000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA2B0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,248C6802028
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
       mov       rcx,248C68069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B773578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,248C68098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B5CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,248C6800528
       mov       r12,[rdx]
       mov       rdx,248C68098E0
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B563FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B5CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B5ACF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B5CB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B773580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,248C68069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B773580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,14B4ED03020
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
       mov       rcx,7FFF7DC64E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14B3ED03598
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,14B3ED06490
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,14B4ED01568
       mov       r15,[rdx]
       mov       rdx,14B3ED06498
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
       call      qword ptr [7FFF7DC59E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,14B3ED03598
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
       mov       rcx,7FFF7DC64E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14B3ED03598
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7BA2B000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA2B0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,14ED3402028
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
       mov       rcx,14ED34069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B773578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,14ED34098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B5CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,14ED3400528
       mov       r12,[rdx]
       mov       rdx,14ED34098E0
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B563FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B5CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B5ACF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B5CB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B773580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,14ED34069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B773580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,137C02D1028
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
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,137C02D59A8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,137C02D88A0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,137E02D1568
       mov       r15,[rdx]
       mov       rdx,137C02D88A8
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
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,137C02D59A8
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
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,137C02D59A8
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7BC2B300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BC2B3D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1CAE3002028
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
       mov       rcx,1CAE30069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B973578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1CADF000CE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1CAE3000528
       mov       r12,[rdx]
       mov       rdx,1CADF000CE8
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B763FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B7ACF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7CB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B973580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1CAE30069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B973580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,180068D3020
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
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,180068D79A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,180268D1CA0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,180068D1568
       mov       r15,[rdx]
       mov       rdx,180268D1CA8
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
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,180068D79A0
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
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,180068D79A0
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7BC2B000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BC2B0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,194FCC02028
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
       mov       rcx,194FCC069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B973578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,19508C00CE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,194FCC00528
       mov       r12,[rdx]
       mov       rdx,19508C00CE8
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B763FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B7ACF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7CB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B973580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,194FCC069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B973580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,170406C3020
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
       mov       rcx,7FFF7DC74E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,170406C79A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,170406CB8B0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,170406C1568
       mov       r15,[rdx]
       mov       rdx,170406CB8B8
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
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,170406C79A0
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
       mov       rcx,7FFF7DC74E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,170406C79A0
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FFF7BC1B000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BC1B0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1A498002028
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
       mov       rcx,1A4980069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFF7B963578]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1A49C001CF8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1A498000528
       mov       r12,[rdx]
       mov       rdx,1A49C001D00
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFF7B753FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B79CF28]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFF7B7BB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B963580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1A4980069A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF7B963580]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DE12950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DE13100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,2A2C1143DF8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,2A2C1145630
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,2A2E1143020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7B65B330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B1DCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B39BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,231AB4014F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,231AF402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,231AF402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B1FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,231AF407430
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B003660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B1FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B1FB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B39BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B377928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B39B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B39BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B39D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B16FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B1FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B39BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B377928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B39B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B39BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B39D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B16FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7AED8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B39BBE8]
       mov       r12,rax
       mov       rcx,231AB401500
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B39BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B39B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B39BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B39D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B16FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B39BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B39D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B195750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7AEE1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B39BBE8]
       mov       r15,rax
       mov       rcx,231AB401508
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B39BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B39B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B39BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B39D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B16FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B39BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B39D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B195750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B1FB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B1FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B1FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B1FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B1FB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,231AB400668
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B1FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B191C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B191C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B39BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B206888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B39B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B39BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B39D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B16FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B39BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B16FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7ADB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B16FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,231AF402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7ADB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7ADB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B195750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DE22950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DE23100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,162439E3DF8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,162439E5630
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DE22950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE22950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,162639E3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9F4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC4B330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B7CCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B98BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,2B0DE0098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,2B0DE002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,2B0DE002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,2B0DE007430
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B5F3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B7EB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B98BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B967928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B7EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B98BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B967928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7B4C8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B98BBE8]
       mov       r12,rax
       mov       rcx,2B0DE0098E0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B98BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B98BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7B4D1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B98BBE8]
       mov       r15,rax
       mov       rcx,2B0DE0098E8
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B98BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B98BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B7EB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B7EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B7EB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,2B0DE008A48
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B98BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B75FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B0DE002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DE02950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DE03100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,202268A8200
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,202268A9A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE02950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,202268A3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9D4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC5B030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B7DCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B99BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,136B1C064E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,136B5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,136B5C02028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,136B1C03028
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B603660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B7FB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B977928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B7FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B99BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B977928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7B4D8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B99BBE8]
       mov       r12,rax
       mov       rcx,136B1C064F0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7B4E1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B99BBE8]
       mov       r15,rax
       mov       rcx,136B1C064F8
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B7FB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B7FB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7FB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7FB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B7FB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,136B1C04640
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B791C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B99BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B99B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B99D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B99BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B76FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B6499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,136B5C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DE02950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DE03100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,1888F703DF8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,1888F705630
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DE02950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE02950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,188AF703020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9D4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC4B330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B7CCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B98BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,19B960054D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,19B9A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,19B9A002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,19B96003028
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B5F3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B7EB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B98BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B967928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B7EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B98BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B967928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7B4C8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B98BBE8]
       mov       r12,rax
       mov       rcx,19B960054D8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B98BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B98BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7B4D1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B98BBE8]
       mov       r15,rax
       mov       rcx,19B960054E0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B98BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B98BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B7EB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B7EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B7EB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,19B96004640
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B98BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B98B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B98D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B98BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B75FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19B9A002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B61D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DE12950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DE13100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,26C6ACA8200
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,26C6ACA9A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,26C6ACA3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BA4B030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B5CCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B78BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,2874D0098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,2874D002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B4399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,2874D002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B5EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,2874D007430
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B3F3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B5EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B5EB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B78BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B767928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B78B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B78BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B78D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B55FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B5EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B78BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B767928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B78B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B78BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B78D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B55FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7B2C8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B78BBE8]
       mov       r12,rax
       mov       rcx,2874D0098E0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B78BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B78B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B78BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B78D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B55FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B3F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B78BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B78D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B585750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7B2D1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B78BBE8]
       mov       r15,rax
       mov       rcx,2874D0098E8
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B78BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B78B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B78BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B78D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B55FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B3F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B78BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B78D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B585750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B5EB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B5EB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B5EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B5EB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B5EB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,2874D008A48
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B5EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B581C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B581C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B78BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B5F6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B78B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B78BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B78D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B55FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B3F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B78BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B55FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7B1A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B55FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B4399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2874D002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B1A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B1A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B41D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B585750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DE12950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DE13100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,1AA6D218200
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,1AA6D219A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,1AA6D213020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC3B030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B7BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,214230054D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,21427002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,21427002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,21423003028
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B5E3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7DB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B7DB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B957928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B957928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7B4B8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B97BBE8]
       mov       r12,rax
       mov       rcx,214230054D8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7B4C1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B97BBE8]
       mov       r15,rax
       mov       rcx,214230054E0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B7DB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7DB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B7DB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,21423004640
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B74FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21427002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DE12950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DE13100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,221EB8B8200
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,2220B8B1658
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,221EB8B3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC3B330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B7BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,208424098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,20842402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,20842402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,20842407430
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B5E3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7DB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B7DB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B957928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B957928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7B4B8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B97BBE8]
       mov       r12,rax
       mov       rcx,208424098E0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7B4C1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B97BBE8]
       mov       r15,rax
       mov       rcx,208424098E8
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B7DB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7DB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B7DB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,20842408A48
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B74FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20842402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DE12950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DE13100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,19DD7AF8200
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,19DD7AF9A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DE12950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DE12950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,19DD7AF3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC3B330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B7BCF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B97BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,1AC4A4098D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,1AC4A402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,1AC4A402028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,1AC4A407430
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B5E3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7DB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B7DB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B957928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B97BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B957928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7B4B8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B97BBE8]
       mov       r12,rax
       mov       rcx,1AC4A4098E0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7B4C1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B97BBE8]
       mov       r15,rax
       mov       rcx,1AC4A4098E8
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B7DB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7DB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7DB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B7DB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,1AC4A408A48
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B771C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B97BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B97B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B97D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B97BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B74FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B6299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1AC4A402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B60D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7DC59E58]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L25
       mov       rcx,rbp
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
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       mov       rdx,7FFF7DDF2950
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
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,97A
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
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
       mov       ecx,996
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L07:
       mov       rcx,rsi
       mov       rdx,rbp
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
       cmp       ebx,0FFFFFFFF
       je        short M01_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L20
M01_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L12:
       xor       ebx,ebx
       mov       rcx,7FFF7DDF3100
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M01_L13:
       mov       r9,254F7C73DF8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M01_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M01_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L15:
       cmp       r15d,ebp
       jae       near ptr M01_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M01_L24
       jmp       near ptr M01_L13
M01_L18:
       sub       ebp,ebx
       jo        near ptr M01_L24
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
       jbe       short M01_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L21
M01_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L21:
       cmp       r14d,0FFFFFFFF
       je        short M01_L22
       cmp       r14d,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rdx,254A7C71658
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L23:
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
M01_L24:
       call      CORINFO_HELP_OVERFLOW
M01_L25:
       mov       ecx,4D
       mov       rdx,7FFF7DDF2950
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,966
       mov       rdx,7FFF7DDF2950
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
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,254C7C73020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFF7D9C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFF7D9C4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7BC2B330]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FFF7B7ACF28]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 179
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
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+90]
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFF7B96BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],2
       jl        near ptr M01_L29
       lea       rcx,[r15+0C]
       mov       rdx,259E0000CE0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L30
       lea       rcx,[r15+10]
       mov       rdx,259DC002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L31
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L31
M01_L02:
       mov       rax,259DC002028
       mov       rcx,[rax]
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7CB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L04:
       xor       r12d,r12d
       mov       r9,259DC007430
       mov       r15,[r9]
M01_L05:
       mov       rdx,r15
       mov       ebx,[rdi+8]
       mov       r9d,ebx
       sub       r9d,r12d
       mov       rcx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B5D3660]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       ebp,eax
       test      ebp,ebp
       jl        near ptr M01_L22
       mov       r9d,ebp
       sub       r9d,r12d
       jo        near ptr M01_L28
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7CB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       jae       near ptr M01_L34
       mov       edx,ebp
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF7B7CB3C0]; System.Text.StringBuilder.Append(Char)
       mov       r12d,ebp
       add       r12d,1
       jo        near ptr M01_L28
       jmp       near ptr M01_L05
M01_L07:
       mov       rcx,rbp
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
       call      qword ptr [7FFF7B96BEA0]
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFF7B947928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      qword ptr [7FFF7B7CB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L06
M01_L11:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
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
       call      qword ptr [7FFF7B96BEA0]
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFF7B947928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       r15,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       call      qword ptr [7FFF7B4A8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L16
       call      qword ptr [7FFF7B96BBE8]
       mov       r12,rax
       mov       rcx,259E0000CE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B765750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      qword ptr [7FFF7B4B1708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L18
       call      qword ptr [7FFF7B96BBE8]
       mov       r15,rax
       mov       rcx,259E0000CF0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L17
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L17:
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAE0]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B765750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF7B7CB288]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFF7B7CB258]; System.Text.StringBuilder.Append(Char, Int32)
M01_L20:
       cmp       ebx,0FFFFFFFF
       je        short M01_L21
       cmp       ebx,0FFFFFFFE
       jne       near ptr M01_L24
M01_L21:
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
M01_L22:
       sub       ebx,r12d
       jo        near ptr M01_L28
       mov       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,r12d
       call      qword ptr [7FFF7B7CB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L23
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L25
M01_L23:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      qword ptr [7FFF7B7CB258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF7B7CB288]; System.Text.StringBuilder.Append(System.String)
M01_L25:
       cmp       r14d,0FFFFFFFF
       je        short M01_L26
       cmp       r14d,0FFFFFFFE
       jne       short M01_L27
M01_L26:
       mov       rdx,259DC008A48
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF7B7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L27:
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
M01_L28:
       call      CORINFO_HELP_OVERFLOW
M01_L29:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B761C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L32
       call      qword ptr [7FFF7B96BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6888
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B96B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B96D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L32:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B96BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L33:
       mov       ecx,2E7
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B73FF90]
       int       3
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2068
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
       call      qword ptr [7FFF7B6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,259DC002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B5FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7B765750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

