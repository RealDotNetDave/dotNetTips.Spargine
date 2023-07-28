## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 109
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
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
       mov       ecx,2F3
       mov       rdx,7FFA98B83E50
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
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [rbp+8],edi
       mov       rdx,rbp
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,1E21E443BB0
       mov       rdi,[rcx]
       mov       ecx,0AE2
       mov       rdx,7FFA98B83E50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       mov       rdx,rsi
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       mov       rcx,rdx
       lea       rdx,[rsp+28]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 304
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,2
       mov       r8d,0A
       mov       r9d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
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
       mov       ecx,2F3
       mov       rdx,7FFA98B63E50
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
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [r14+8],edi
       mov       rdx,r14
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,1DAFF211048
       mov       rdi,[rcx]
       mov       ecx,0AE2
       mov       rdx,7FFA98B63E50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       test      ebx,ebx
       jle       short M01_L04
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L05
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
M01_L05:
       test      eax,eax
       jne       short M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,2E7
       mov       rdx,7FFA98B63E50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L06:
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bp
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       mov       rdx,rsi
       mov       [rsp+20],rax
       mov       [rsp+28],ecx
       mov       rcx,rdx
       lea       rdx,[rsp+20]
       mov       r8d,ebx
       mov       r9d,edi
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 378
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 109
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
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
       mov       ecx,2F3
       mov       rdx,7FFA98B93E50
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
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [rbp+8],edi
       mov       rdx,rbp
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,1D5557E3BB0
       mov       rdi,[rcx]
       mov       ecx,0AE2
       mov       rdx,7FFA98B93E50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       mov       rdx,rsi
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       mov       rcx,rdx
       lea       rdx,[rsp+28]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 304
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,2BE19803020
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rsi
       mov       edx,edi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,7FFA98B84600
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2BE39809CC8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-30],rdx
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L02
       mov       rcx,2BE19801568
       mov       r14,[rcx]
       mov       rcx,2BE79801C90
       mov       r15,[rcx]
M01_L01:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rcx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L04
       cmp       ebx,edi
       jg        short M01_L01
M01_L02:
       mov       rdx,[rbp-30]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFA989D58B8]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
M01_L03:
       jmp       short M01_L06
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,2BE39809CC8
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFA98B84600
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2BE39809CC8
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 408
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       xor       edx,edx
       call      qword ptr [7FFADFFC3750]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE037FBA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
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
       mov       edi,edx
       mov       rcx,rsi
       call      qword ptr [7FFADFFC5B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,243ED802028
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
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFADFFC3720]; DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,243FD804F90
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFAE01CCEE0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
       mov       rcx,243ED800528
       mov       r15,[rcx]
       mov       rcx,243FB800CF0
       mov       r12,[rcx]
M01_L01:
       mov       ecx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       r8,r15
       movzx     ecx,byte ptr [rcx]
       mov       rdx,r12
       call      qword ptr [7FFADFDD3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rax,[rbp-38]
       cmp       [rax],al
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFADFE2B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rax,[rbp-38]
M01_L02:
       add       ebx,1
       jo        short M01_L05
       cmp       r14d,ebx
       jg        short M01_L01
M01_L03:
       mov       rdx,[rbp-38]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFADFE17790]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFADFFC5B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L06
M01_L04:
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,2
       call      qword ptr [7FFADFBB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFADFBB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       jmp       short M01_L04
M01_L07:
       mov       rcx,rdi
       mov       rdx,[rbp-38]
       call      qword ptr [7FFAE01CCEE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rbx
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
       mov       rcx,243FD804F90
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-38]
       call      qword ptr [7FFAE01CCEE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 391
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L04
       mov       rax,17CCB8E1BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA989A38B8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
       mov       rcx,7FFA98B74600
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,17CCB8EE060
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-30],rdx
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L01
       mov       rcx,17CCB8E1568
       mov       r14,[rcx]
       mov       rcx,17CCB8F3FE0
       mov       r15,[rcx]
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rcx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,[rbp-30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L02
       cmp       ebx,edi
       jg        short M01_L00
M01_L01:
       mov       rdx,[rbp-30]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFA989C58B8]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L03
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       mov       rcx,17CCB8EE060
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFA98B73E50
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,7BF
       mov       rdx,7FFA98B73E50
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
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFA98B74600
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,17CCB8EE060
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 438
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],61
       mov       word ptr [rax+12],7A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass4_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass4_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,2F3
       mov       rdx,7FFA98B83E50
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
       je        short M01_L05
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
       mov       ecx,0A72
       mov       rdx,7FFA98B83E50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1E4393C3020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1E4393C3020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
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
M01_L00:
       cmp       rsi,rdi
       je        short M01_L02
       test      rsi,rsi
       je        near ptr M01_L05
       test      rdi,rdi
       je        near ptr M01_L05
       cmp       ebx,5
       jne       short M01_L04
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L03
M01_L01:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       cmp       ebx,5
       ja        near ptr M01_L08
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       mov       r8d,ebx
       lea       rcx,[7FFA98CD99E0]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L01
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
M01_L05:
       cmp       ebx,5
       ja        short M01_L08
       jmp       near ptr M01_L01
M01_L06:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
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
       jmp       near ptr M01_L06
       mov       rcx,7FFA987A4938
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1E4393C1520
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
       jmp       near ptr M01_L06
; Total bytes of code 429
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,1F783ED3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1F783ED1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1F783ED1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[System.Text.Encoding.GetString(Byte[])]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 144
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03213D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02BB180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03210C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA84C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03212A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B7CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBB7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B7CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDD9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDD9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03210D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03413D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02E9CC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03410C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03412A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03410D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03113D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02B9CC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03110C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA84C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03112A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B79C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBB7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B79C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDD9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDD9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03110D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE0321F48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02BD180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE0321C30]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA84C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE0321E10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B9CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBB7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B9CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDD9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDD9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE0321C48]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03413D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02E9CC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03410C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03412A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03410D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987B4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03313D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02CB180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03310C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA94C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03312A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C7CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBC7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C7CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDE9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDE9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03310D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03316D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02D9CC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03313C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromBrotliAsync>d__11 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAA4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03315A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02D79C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBD7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02D79C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDF9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDF9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03313D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03313D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02CBCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03310C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA94C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03312A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C97E0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBC7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C97E0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDE9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDE9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03310D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE0351F48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02ED180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE0351C30]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE0351E10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E9CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E9CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE0351C48]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987B4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03513D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02EB180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03510C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03512A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E7CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E7CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03510D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03436D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02EDCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03433C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03435A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02EB9C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02EB9C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03433D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03516D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02EBCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03513C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03515A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E99C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E99C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03513D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03413D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02E9CC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03410C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03412A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03410D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03336D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02CBCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03333C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromGZipAsync>d__12 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA94C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03335A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C99C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBC7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C99C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDE9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDE9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03333D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,4E70F33C
       mov       r9d,7D7DBF36
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,8245D92
       mov       r9d,0F05F4151
       call      qword ptr [7FFADFFAB3A8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0341B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0D5B3EFAF
       mov       r9d,0D89FBFA6
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,3927C020
       mov       r9d,0D72C708D
       call      qword ptr [7FFADFFBB3A8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0341318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,4DE581B0
       mov       r9d,3D90128C
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,9D8885BA
       mov       r9d,0EEBA6079
       call      qword ptr [7FFADFF9B3A8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE02FFFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,2D47B10
       mov       r9d,0AEF9DB05
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0FE140E68
       mov       r9d,0D2914DAA
       call      qword ptr [7FFADFFAB3A8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0343318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,312C281D
       mov       r9d,8C611B5
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,859DAD4A
       mov       r9d,188B4E0F
       call      qword ptr [7FFADFFAB3A8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE030FFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0D4E28E59
       mov       r9d,73BCC6D1
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,4397308A
       mov       r9d,0DCFA6B17
       call      qword ptr [7FFADFFAB3A8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0341318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,20D77E93
       mov       r9d,2B877143
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0CCB1F048
       mov       r9d,7E65279E
       call      qword ptr [7FFADFF9B3A8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0321318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,1A5D7A93020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
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
; Total bytes of code 96
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
       mov       rdx,7FFA98D969A0
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
       mov       rdx,7FFA98B73E50
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,7BF
       mov       rdx,7FFA98B73E50
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
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M02_L00
       mov       rax,1A5D7A93020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rcx,1A5D7A9E0B8
       mov       rbx,[rcx]
       test      rsi,rsi
       je        short M02_L03
       mov       rbp,rsi
       mov       rdx,rdi
       mov       edi,[rbx+48]
       test      dil,40
       jne       short M02_L02
       xor       r14d,r14d
M02_L01:
       test      rdx,rdx
       je        short M02_L04
       mov       rcx,[rbx+20]
       mov       [rsp+20],rcx
       mov       [rsp+28],edi
       mov       rcx,[rbx+30]
       mov       r8,[rbx+18]
       mov       r9d,[rbx+4C]
       call      System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],r14d
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       rbp,rsi
       mov       r14d,[rbp+8]
       jmp       short M02_L01
M02_L03:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M02_L04:
       mov       ecx,0E
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
; Total bytes of code 193
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1DC334910E8
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,44A91B04D791
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FFA987B4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DC73496F98
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,44A91B04D791
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1DC13492FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D7E7A8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1DC13492FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D7E7A8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,15E6DC10428
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFADF853258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,90E6B965E707
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF8531E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF853270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF853288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FFADF853318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF853270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8532A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8532B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,15E6DC0C8C0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE6BEC0]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,15E6DC0C8C0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE6BEC0]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,90E6B965E707
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FFADF604000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FFADF604000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFADF87D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFADFA75750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FFADFA87768]
       int       3
M01_L15:
       call      qword ptr [7FFADFA87498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,250976094A8
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,0EEDEE07AAB4E
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FFA987A4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,250B7606F98
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,0EEDEE07AAB4E
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,25097602FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D6CF08]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,25097602FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D6CF08]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,152C6412420
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFADFBC3258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0FC6C771B4EA0
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADFBC31E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADFBC3270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADFBC3288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FFADFBC3318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADFBC3270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADFBC32A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADFBC32B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,152C6402008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFAE01CA0E0]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,152C6402008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFAE01CA0E0]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,0FC6C771B4EA0
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FFADF974000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FFADF974000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFADFBED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFADFDE5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FFADFDF7768]
       int       3
M01_L15:
       call      qword ptr [7FFADFDF7498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1F155DB3438
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,8222B309256F
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FFA987D4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F155DB1350
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,8222B309256F
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1F155DA2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D877B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1F155DA2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D877B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,24792012420
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFADFBD3258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0BB218F6DC0E9
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADFBD31E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADFBD3270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADFBD3288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FFADFBD3318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADFBD3270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADFBD32A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADFBD32B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,24792002008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFAE01D9C28]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,24792002008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFAE01D9C28]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,0BB218F6DC0E9
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FFADF984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FFADF984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFADFBFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFADFDF5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FFADFE07768]
       int       3
M01_L15:
       call      qword ptr [7FFADFE07498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1D11F8E10E8
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,79AF31912079
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FFA987A4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D0FF8F1350
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,79AF31912079
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1D0FF8E2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D577B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1D0FF8E2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D577B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,28D5C0000D0
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFADF843258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0FE45554FF73
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF8431E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF843270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF843288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FFADF843318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF843270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8432A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8432B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,28D58002008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE4C370]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,28D58002008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE4C370]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,0FE45554FF73
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FFADF5F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FFADF5F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFADF86D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFADFA65750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FFADFA77768]
       int       3
M01_L15:
       call      qword ptr [7FFADFA77498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1F3AEB63438
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,539EC0247EA6
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FFA98794938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F3AEB61350
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,539EC0247EA6
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FFA98684000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FFA98684000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1F3AEB52FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D477B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1F3AEB52FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D477B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,1BD2BC12420
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFADF873258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,87510B99D31C
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF8731E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF873270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF873288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FFADF873318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF873270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8732A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8732B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,1BD2BC02008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE79350]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,1BD2BC02008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE79350]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,87510B99D31C
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FFADF624000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FFADF624000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFADF89D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFADFA95750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FFADFAA7768]
       int       3
M01_L15:
       call      qword ptr [7FFADFAA7498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,26C09E554F0
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,7C31DC38D23
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FFA987B4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26C29E5CF48
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,7C31DC38D23
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,26C09E52FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D677B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,26C09E52FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D677B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,28B13012420
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFADF863258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,305A04866C15
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF8631E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF863270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF863288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FFADF863318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF863270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8632A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8632B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,28B13002008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE6C370]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,28B13002008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE6C370]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,305A04866C15
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FFADF614000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FFADF614000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFADF88D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFADFA85750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FFADFA97768]
       int       3
M01_L15:
       call      qword ptr [7FFADFA97498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1CF47793438
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,0D2CA2C7EE33
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FFA987C4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1CF47791350
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,0D2CA2C7EE33
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1CF47782FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D777B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1CF47782FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA98D777B8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,22131812420
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFADF863258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,9C7F4DB1F96A
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF8631E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF863270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FFADF863288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FFADF863318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFADF863270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8632A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFADF8632B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,22131802008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE69350]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,22131802008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFADFE69350]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,9C7F4DB1F96A
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FFADF614000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FFADF614000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFADF88D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFADFA85750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FFADFA97768]
       int       3
M01_L15:
       call      qword ptr [7FFADFA97498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+20],rax
       mov       rdi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 265
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
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
       mov       ecx,2F3
       mov       rdx,7FFA98B73E50
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
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0F0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rax,[rbx]
       mov       [rsp+0E0],rax
       mov       eax,[rbx+8]
       mov       [rsp+0E8],eax
       cmp       dword ptr [rsp+0E8],0
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,[rsp+0E0]
       mov       r9d,[rsp+0E8]
       mov       edx,0D
       mov       r8d,0A
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       ebp,eax
       cmp       ebp,0FFFFFFFF
       jne       near ptr M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       mov       rax,[rsp+0E0]
       mov       edx,[rsp+0E8]
       xor       ecx,ecx
       lea       r8,[rsp+80]
       mov       [r8],rax
       mov       [r8+8],edx
       lea       rax,[rsp+90]
       mov       [rax],rcx
       xor       edx,edx
       mov       [rax+8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,[rsp+0E8]
       sub       eax,1
       jo        near ptr M02_L04
       cmp       ebp,eax
       jge       near ptr M02_L03
       cmp       ebp,[rsp+0E8]
       jae       near ptr M02_L06
       mov       rax,[rsp+0E0]
       movsxd    rdx,ebp
       cmp       word ptr [rax+rdx*2],0D
       jne       near ptr M02_L03
       mov       eax,ebp
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,[rsp+0E8]
       jae       near ptr M02_L06
       mov       rdx,[rsp+0E0]
       movsxd    rax,eax
       movzx     eax,word ptr [rdx+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r14d,ebp
       mov       eax,[rsp+0E8]
       mov       r15d,eax
       cmp       r14,r15
       ja        near ptr M02_L05
       mov       rax,[rsp+0E0]
       lea       rdx,[r14+2]
       cmp       rdx,r15
       ja        near ptr M02_L05
       lea       rdx,[rax+r14*2]
       lea       rcx,[rsp+0A0]
       mov       [rcx],rax
       mov       [rcx+8],ebp
       lea       rax,[rsp+0B0]
       mov       [rax],rdx
       mov       dword ptr [rax+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       lea       r12,[rsp+0E0]
       add       ebp,2
       jo        near ptr M02_L04
       mov       eax,[r12+8]
       mov       edx,eax
       sub       edx,ebp
       mov       ecx,ebp
       mov       r8d,edx
       add       rcx,r8
       mov       eax,eax
       cmp       rcx,rax
       ja        near ptr M02_L05
       mov       rax,[r12]
       mov       ecx,ebp
       lea       rax,[rax+rcx*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r14d,ebp
       mov       eax,[rsp+0E8]
       mov       r15d,eax
       cmp       r14,r15
       ja        near ptr M02_L05
       mov       rax,[rsp+0E0]
       lea       rdx,[r14+1]
       cmp       rdx,r15
       ja        near ptr M02_L05
       lea       rdx,[rax+r14*2]
       lea       rcx,[rsp+0C0]
       mov       [rcx],rax
       mov       [rcx+8],ebp
       lea       rax,[rsp+0D0]
       mov       [rax],rdx
       mov       dword ptr [rax+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       lea       r12,[rsp+0E0]
       add       ebp,1
       jo        short M02_L04
       mov       eax,[r12+8]
       mov       edx,eax
       sub       edx,ebp
       mov       ecx,ebp
       mov       r8d,edx
       add       rcx,r8
       mov       eax,eax
       cmp       rcx,rax
       ja        short M02_L05
       mov       rax,[r12]
       mov       ecx,ebp
       lea       rax,[rax+rcx*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 852
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       mov       rcx,rax
       mov       [rbp-20],rcx
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp-20]
       mov       r11,7FFA986A0950
       call      qword ptr [7FFA986A0950]
       mov       [rbp-18],rax
       mov       rdi,[rsi+18]
       mov       rdx,[rbp-18]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       rcx,[rbp-20]
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp-20]
       mov       r11,7FFA986A0958
       call      qword ptr [7FFA986A0958]
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M00_L02
       mov       rcx,[rbp-20]
       mov       r11,7FFA986A0958
       call      qword ptr [7FFA986A0958]
M00_L02:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 239
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2F3
       mov       rdx,7FFA98B63E50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],2C
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       mov       [rsp+20],rax
       mov       [rsp+28],ecx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
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
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,2B131D13020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,2B131D11B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2B131D11AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFA9888EA18]; System.Text.Encoding.GetBytes(System.String)
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
; Total bytes of code 140
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03216D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02BB180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03213C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA84C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03215A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B7CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBB7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B7CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDD9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDD9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03213D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987B4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03313D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02CBCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03310C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA94C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03312A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C99C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBC7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C99C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDE9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDE9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03310D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03413D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02DB180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03410C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAA4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03412A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02D7CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBD7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02D7CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDF9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDF9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03410D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987B4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03416D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02E9CC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03413C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03415A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03413D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE0321C48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02BD180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE0321930]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA84C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE0321B10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B9CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBB7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B9CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDD9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDD9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE0321948]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE0311F48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02BD180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE0311C30]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA84C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE0311E10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B9CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBB7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B9CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDD9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDD9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE0311C48]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987B4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03333D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02DDCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03330C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAA4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03332A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02DB9C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBD7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02DB9C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDF9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDF9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03330D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987A4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE0351C48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02ED180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE0351930]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE0351B10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E9CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E9CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE0351948]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987D4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03333D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02DDCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03330C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAA4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03332A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02DB9C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBD7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02DB9C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDF9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDF9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03330D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987B4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03416D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02E9CC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03413C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAB4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03415A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBE7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02E79C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFE09AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFE09270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03413D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987B4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE0331C48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02CD180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE0331930]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA94C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE0331B10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C9CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBC7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02C9CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDE9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDE9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE0331948]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987B4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE0321F48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02BD180]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE0321C30]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA84C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE0321E10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B9CF0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBB7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02B9CF0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDD9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDD9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE0321C48]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03136D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02BDCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03133C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFA84C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03135A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02BB9C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBB7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02BB9C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDD9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDD9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03133D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFA987C4938
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAE03433D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFAE02DBCC0]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFAE03430C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFADFAA4C10
       mov       edx,2D2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFAE03432A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02D99C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFADFBD7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFAE02D99C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFADFDF9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFADFDF9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFAE03430D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

