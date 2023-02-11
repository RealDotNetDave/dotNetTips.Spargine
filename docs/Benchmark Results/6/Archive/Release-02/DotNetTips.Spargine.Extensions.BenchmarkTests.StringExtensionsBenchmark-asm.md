## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       mov       rdx,[rcx+210]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1C3386D19A8
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rcx+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 42
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,64
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       push      rsi
       sub       rsp,20
       mov       esi,edx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF893F57860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       test      esi,esi
       jle       short M01_L03
       mov       eax,1
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,0A54
       mov       rdx,7FF893F57860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L05:
       test      rcx,rcx
       je        short M01_L06
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax+8],esi
       sete      al
       movzx     eax,al
       add       rsp,20
       pop       rsi
       ret
M01_L06:
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 189
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,5
       mov       r8d,64
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       esi,edx
       mov       edi,r8d
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF893F27860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       test      esi,esi
       jl        short M01_L03
       cmp       esi,edi
       setle     al
       movzx     eax,al
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,0A62
       mov       rdx,7FF893F27860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L05:
       cmp       edi,esi
       jl        short M01_L06
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L07
M01_L06:
       xor       eax,eax
M01_L07:
       test      eax,eax
       jne       short M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       ecx,0A76
       mov       rdx,7FF893F27860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L08:
       test      rcx,rcx
       je        short M01_L11
       mov       eax,[rcx+8]
       cmp       eax,esi
       jl        short M01_L09
       cmp       eax,edi
       setle     al
       movzx     eax,al
       jmp       short M01_L10
M01_L09:
       xor       eax,eax
M01_L10:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L11:
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 262
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0A0]
       test      rdi,rdi
       je        near ptr M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,157C6CBA5A0
       mov       rcx,[rcx]
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,157C6CBA5A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8d,1
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 168
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,157C6CB3020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,157C6CB8118
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M03_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M03_L02
       xor       esi,esi
M03_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M03_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M03_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M03_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M00_L00
       mov       rdx,1E1246021C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,1E114603020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M02_L01
       test      rsi,rsi
       je        near ptr M02_L04
       test      rdi,rdi
       je        near ptr M02_L04
       cmp       ebx,5
       jne       short M02_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M02_L02
M02_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       cmp       ebx,5
       ja        near ptr M02_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L03:
       cmp       ebx,5
       ja        short M02_L06
       mov       r8d,ebx
       lea       rcx,[7FF894010B40]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8940209A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M02_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L04:
       cmp       ebx,5
       ja        short M02_L07
       jmp       near ptr M02_L00
M02_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FF893C64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FF893C64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M02_L05
       mov       rcx,7FF893D74928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1E114601520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M02_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,1B35A2D3300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 117
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF894103CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FF893F77860
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF893F77860
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
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1B35A2D2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF894041860]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF8940429C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,1B35A2D32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,1B35A2D32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FF893F77860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,1B37A2D57A0
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FF8940315F0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1F7CEE73020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rcx+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 39
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,2460C53B5B8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L02
       cmp       dword ptr [rdx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A08
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,2E2505A19A8
       mov       rdx,[rdx]
       mov       r8,2E2505A19B0
       mov       r8,[r8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L06
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L06
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L07
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L07
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,0A40
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L08
       xor       eax,eax
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A4C
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       dword ptr [rsp+20],4
       mov       ebp,[rsi+8]
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       edi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,edi
       mov       rcx,rsi
       mov       edx,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Substring(Int32, Int32)
M01_L06:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L07:
       mov       eax,1
       jmp       near ptr M01_L02
M01_L08:
       mov       eax,1
       jmp       near ptr M01_L04
; Total bytes of code 399
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M00_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,2AE5FF33020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 30
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
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
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF893F37860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L06
M01_L03:
       movsxd    rcx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       cmp       ecx,100
       jae       short M01_L09
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M01_L05
       jmp       short M01_L07
M01_L04:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     ebp,al
       test      ebp,ebp
       je        short M01_L07
M01_L05:
       add       edi,1
       jo        short M01_L08
       cmp       ebx,edi
       jg        short M01_L03
M01_L06:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 224
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FF893FF15F0]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+218]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+218]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+218]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+218]
       cmp       ecx,100
       jae       short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 89
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+1C8]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexCreditCard()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexCreditCard()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,233B00019A8
       mov       rdx,[rdx]
       mov       r8,23380007C78
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,23380003020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,23380008118
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+1D0]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexCurrencyCode()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexCurrencyCode()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1CAD797B5B8
       mov       rdx,[rdx]
       mov       r8,1CAD7977C78
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,1CAD7973020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,1CAD7978118
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+1D8]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexDomain()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,9
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexDomain()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,202BE3A19A8
       mov       rdx,[rdx]
       mov       r8,202AE3A5C80
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,202AE3A1028
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,202AE3A6120
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+1E0]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexEmail()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,9
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexEmail()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1EFAEBC5980
       mov       rdx,[rdx]
       mov       r8,1EFAEBC3870
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,1EFBEBC3020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,1EFAEBC3D10
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 30
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,4D
       mov       rdx,7FF893F57860
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF893F57860
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
; Total bytes of code 110
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+200]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexFirstLastName()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,9
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexFirstLastName()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,26508EC21C0
       mov       rdx,[rdx]
       mov       r8,26518EC3870
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,264F8EC3020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,26518EC3D10
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,2A7ED5E9F78
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,2A7ED5E7C60
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+1F0]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexISBN()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexISBN()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1BD05CD19A8
       mov       rdx,[rdx]
       mov       r8,1BD15CD7C78
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,1BD15CD3020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,1BD15CD8118
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1A71DB485A8
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,1A71DB45C70
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M00_L00
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rcx+18]
       mov       [rdx+54],al
       ret
; Total bytes of code 31
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+1F8]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexOneToSevenAlpha()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexOneToSevenAlpha()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,191897B29C0
       mov       rdx,[rdx]
       mov       r8,191997B3870
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,191797B3020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,191997B3D10
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexScientific()
       mov       rdi,rax
       mov       rcx,292E7358DA8
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L01
       test      rdi,rdi
       je        short M00_L01
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L01
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       r9,rbx
       test      byte ptr [rcx+48],40
       jne       short M00_L03
       xor       edi,edi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],0A
       mov       [rsp+30],edi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       edi,0A
       jmp       short M00_L00
; Total bytes of code 214
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexScientific()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,292E7358DB0
       mov       rdx,[rdx]
       mov       r8,292E7355C80
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,292E7351028
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,292E7356120
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       mov       [rbp+0FFA8],rsp
       mov       [rbp+10],rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       rsi,r9
       mov       r14d,[rbp+30]
       mov       r15d,[rbp+38]
       mov       r12d,[rbp+40]
       mov       edx,[rsi+8]
       cmp       edx,r12d
       jb        near ptr M04_L06
       cmp       edx,r15d
       jb        near ptr M04_L07
       cmp       [rcx],ecx
       lea       rdx,[rcx+38]
       mov       rcx,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
       test      rax,rax
       je        short M04_L02
M04_L00:
       mov       rdx,rax
M04_L01:
       mov       [rbp+0FFC0],rdx
       add       r15d,r14d
       mov       [rsp+20],r15d
       mov       [rsp+28],r12d
       mov       [rsp+30],ebx
       movzx     ecx,dil
       mov       [rsp+38],ecx
       mov       rcx,[rbp+10]
       mov       r8,[rcx+58]
       mov       [rsp+40],r8
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       mov       r8,rsi
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.RegexRunner.Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
       mov       rsi,rax
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L02:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M04_L04
       mov       r13,[rdx+40]
       test      dword ptr [rdx+48],200
       jne       short M04_L05
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FFB8],rax
M04_L03:
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexInterpreter
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp+0FFB0],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,[rbp+0FFB8]
       call      System.Text.RegularExpressions.RegexInterpreter..ctor(System.Text.RegularExpressions.RegexCode, System.Globalization.CultureInfo)
       mov       r13,[rbp+0FFB0]
       mov       rdx,r13
       jmp       near ptr M04_L01
M04_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L00
M04_L05:
       mov       rcx,292F7351568
       mov       r8,[rcx]
       mov       rcx,r8
       mov       [rbp+0FFB8],rcx
       jmp       short M04_L03
M04_L06:
       mov       ecx,0F
       xor       edx,edx
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
       int       3
M04_L07:
       mov       ecx,8
       mov       edx,2
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       mov       rbp,[rcx+48]
       mov       [rsp+48],rbp
       lea       rbp,[rbp+0A0]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 416
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexString()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,9
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 156
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexString()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,163E4D7B5B8
       mov       rdx,[rdx]
       mov       r8,163E4D77C78
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,163E4D73020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,163E4D78118
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1E8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       mov       rcx,12B8402B5B8
       mov       rcx,[rcx]
       call      System.Text.RegularExpressions.RegexCache.GetOrAdd(System.String)
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.Match(System.String)
       cmp       dword ptr [rax+14],0
       setg      al
       movzx     eax,al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+1D8]
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexUrl()
       mov       rbx,rax
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       test      rbx,rbx
       je        short M00_L00
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8d,9
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_RegexUrl()
       sub       rsp,28
       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,19CF22465C8
       mov       rdx,[rdx]
       mov       r8,19CD2243870
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,19CF2243020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,19CD2243D10
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M04_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M04_L02
       xor       esi,esi
M04_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M04_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M04_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M04_L00
; Total bytes of code 93
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+208]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L03
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF893F37860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rdx,1C040A07688
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.EndsWith(System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L02
       mov       r8d,[rsi+8]
       add       r8d,0FFFFFFFE
       mov       rcx,rsi
       xor       edx,edx
       call      System.String.Substring(Int32, Int32)
       mov       rsi,rax
M01_L02:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF893F37860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A22
       mov       rdx,7FF893F37860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF893F57860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A22
       mov       rdx,7FF893F57860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SubstringTrim()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rcx,rdi
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
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,2B9278C1028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,2B9278C1028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AEA
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A54
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0B00
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AEA
       mov       rdx,7FF893F47860
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTitleCase()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF893C404E0
       call      qword ptr [7FF893FF04E0]
       mov       rcx,rax
       mov       r11,7FF893C404E8
       call      qword ptr [7FF893FF04E8]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FF893D44928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2210E5F1578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2210E5F1558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,220EE5F19A8
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,220EE5F19B0
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF893FF15F0]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FF893C34000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF893C604E0
       call      qword ptr [7FF8940104E0]
       mov       rcx,rax
       mov       r11,7FF893C604E8
       call      qword ptr [7FF8940104E8]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FF8F2ED12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,2FB75AA3020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

