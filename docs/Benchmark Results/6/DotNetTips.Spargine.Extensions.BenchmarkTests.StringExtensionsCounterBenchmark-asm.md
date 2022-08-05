## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,1820F639BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,1ADF5A39BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,28A742E9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,1D5EE7A9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,197CB4C5BC8
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       mov       rcx,2634A4F9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,2CCC9C99BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,1EA0E3F17C0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithRemoveEmptyEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,1
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,2A7349D9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       mov       rcx,1C11AE39BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89407F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,22FEECC9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       rcx,25C1E7A5798
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89409F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89409F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,1C1DBE39BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89408F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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
       mov       rcx,257AAE89BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89405F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89405F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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
       mov       rcx,1CA81707BA8
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89405F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89405F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,21167339BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       mov       rcx,200F66E9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89407F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntriesCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
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
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,2001D4C17C0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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
       mov       ecx,0ADE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,1F54B5B9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       rcx,1DEB8CC17C0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89409F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,1E00F899BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,1F622DB9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       rcx,20631DF7BA8
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89409F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       mov       rcx,1E8A05B5BC8
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,198D5579BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,23936C95798
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitWithTrimEntries()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2
       mov       r8d,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
       xchg      ax,ax
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       rcx,1C14D4E9BA0
       mov       rdi,[rcx]
       mov       ecx,0ACE
       mov       rdx,7FF89409F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89408F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,1A3AB381568
       mov       r14,[rdx]
       mov       rdx,1A38B3850B0
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894262E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89408F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,26180F21568
       mov       r14,[rdx]
       mov       rdx,26170F26478
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894262E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89405F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,2020C321568
       mov       r14,[rdx]
       mov       rdx,2020C32A880
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894232E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89408F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,2C541DB1568
       mov       r14,[rdx]
       mov       rdx,2C531DB1C88
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894262E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,21B26071568
       mov       r14,[rdx]
       mov       rdx,21B2607B898
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894242E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89407F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,19D0EB51568
       mov       r14,[rdx]
       mov       rdx,19CEEB51C88
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894252E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89407F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,12FDC081568
       mov       r14,[rdx]
       mov       rdx,12FDC0878C0
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894252E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,15A02771568
       mov       r14,[rdx]
       mov       rdx,15A0277B898
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894272E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeHash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       xor       edx,edx
       call      DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
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
       mov       rdx,7FF89407F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       shr       edx,1F
       add       edx,eax
       sar       edx,1
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
       mov       rdx,225256B1568
       mov       r14,[rdx]
       mov       rdx,225456B2CA0
       mov       r15,[rdx]
M01_L03:
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L03
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF894252E80]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L05
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       near ptr System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 328
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,297CD011BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942682C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,297CD011568
       mov       r14,[rdx]
       mov       rdx,297ED011C88
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894272E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89409F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,18370251BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942582C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,18370251568
       mov       r14,[rdx]
       mov       rdx,1837025A880
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894262E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89408F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89408F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,25CE23A1BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942582C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,25CE23A1568
       mov       r14,[rdx]
       mov       rdx,25CC23A1C88
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894262E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89408F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89408F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,170B7A61BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942682C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,170B7A61568
       mov       r14,[rdx]
       mov       rdx,170B7A64C98
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894272E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89409F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,2D0B9B91BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942382C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2D0B9B91568
       mov       r14,[rdx]
       mov       rdx,2D0B9B9A880
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894242E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89406F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,213776F1BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942482C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,213776F1568
       mov       r14,[rdx]
       mov       rdx,213876F2CA0
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894252E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89407F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89407F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,29A3FE51BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942682C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,29A3FE51568
       mov       r14,[rdx]
       mov       rdx,29A4FE51C88
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894272E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89409F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,24504971BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942382C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,24504971568
       mov       r14,[rdx]
       mov       rdx,244F4972CA0
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894242E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89406F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeSHA256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,1CA20251BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8942382C0]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1CA20251568
       mov       r14,[rdx]
       mov       rdx,1CA40251C88
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FF894242E80]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89406F278
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+2C0]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       mov       edx,2E
       call      DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       movzx     edx,si
       mov       [rsp+3C],dx
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       ecx,0A22
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       ecx,0A22
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       ecx,0A22
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       ecx,0A22
       mov       rdx,7FF89409F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       ecx,0A22
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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
       mov       ecx,0A22
       mov       rdx,7FF89405F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       ecx,0A22
       mov       rdx,7FF89408F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       ecx,0A22
       mov       rdx,7FF89409F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       mov       ecx,0A22
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1C8883F1028
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1C8883F1028
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894239740]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942495A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FF893C34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FF893C34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D44928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1C8783F1520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1D2D0FD1028
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1D2D0FD1028
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894249740]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942595A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D54928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1D2B0FD1520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,265232D1028
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,265232D1028
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894269860]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942796C1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
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
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D74928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,265432D1520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1E042D83020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1E042D83020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894269860]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942796C1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
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
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D74928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1E042D81520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1C4FE4B3020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1C4FE4B3020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894249860]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942596C1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D54928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1C4FE4B1520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,20D20173020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,20D20173020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894239740]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942495A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FF893C34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FF893C34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D44928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,20D20171520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,20BD8CA3020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,20BD8CA3020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894249740]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942595A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D54928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,20BD8CA1520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1ED26B73020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1ED26B73020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894269860]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942796C1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
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
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D74928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1ED26B71520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,rdx
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,21D22973020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,21D22973020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FF894259740]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FF8942695A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
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
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FF893C54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FF893C54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
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
       jmp       near ptr M01_L05
       mov       rcx,7FF893D64928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,21D22971520
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
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1F8C2E91B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1F8C2E91AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89426EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,208D9231B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,208D9231AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89423EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,21354291B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21354291AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89424EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,26275D21B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,26275D21AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89425EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1ACA9A51B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1ACA9A51AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89422EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1BA10B81B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1BA10B81AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89423EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,2BB118F1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2BB118F1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89422EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1FD76EA1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1FD76EA1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89424EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1EBA5351B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1EBA5351AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF89425EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D74928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D34928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D54928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D74928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromBrotliAsync>d__11.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D34928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D54928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D34928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D54928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D34928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D54928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D74928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D74928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<FromGZipAsync>d__12.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,3282BAEF
       mov       r9d,0C3B50CEC
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0AF45BC84
       mov       r9d,0BDD24C13
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0D7256BD7
       mov       r9d,6DD80E7C
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,81E18AFE
       mov       r9d,0CE247FB8
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0FC28874A
       mov       r9d,6056B74B
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,3802E760
       mov       r9d,1494F4CE
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,874BFB72
       mov       r9d,10816F1
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,5DC8EEC3
       mov       r9d,4C1EBD4B
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,4638AE7E
       mov       r9d,0A0EEA00C
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       r10d,[rcx+rax+0FFFC]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,1A2F89A3020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8940F33C0
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
       mov       rdx,7FF89407F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89407F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89407F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1A3089A1C88
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,2AC91631028
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8941133C0
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
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89409F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,2AC81638470
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,1A537C13020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8941033C0
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
       mov       rdx,7FF89408F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89408F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89408F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1A517C11C88
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,1EF2A323020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8941133C0
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
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89409F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1EF2A32A880
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,2086AFA1028
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8940E33C0
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
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89406F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,2085AFA1C88
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,22693A73020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8940E33C0
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
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89406F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,22683A71C88
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,1E4B82B3020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8940E33C0
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
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89406F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89406F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1E4D82B1C88
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,211C83A3020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8941133C0
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
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89409F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89409F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,211C83AA880
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       mov       rdx,21E12CB3020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
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
       mov       rdx,7FF8940D33C0
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
       mov       rdx,7FF89405F278
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FF89405F278
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FF89405F278
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,21E32CB1C88
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,145149C3190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,222FB777AC2F
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
       mov       rcx,7FF893D44928
       mov       edx,43
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,145149C9388
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
       mov       rcx,222FB777AC2F
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
       mov       rdx,7FF893C34000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C34000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rdi,[rbp+68]
       test      rdi,rdi
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,7FF893D44928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,145149C9390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942444C0]
M01_L32:
       mov       rdi,[rbp+48]
       test      rdi,rdi
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,7FF893D44928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,145149C9390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942444C0]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,18775BC3190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,39620117D9EA
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
       mov       rcx,7FF893D74928
       mov       edx,43
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18775BC9388
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
       mov       rcx,39620117D9EA
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
       mov       rdx,7FF893C64000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C64000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rdi,[rbp+68]
       test      rdi,rdi
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,7FF893D74928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18775BC9390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942744C0]
M01_L32:
       mov       rdi,[rbp+48]
       test      rdi,rdi
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,7FF893D74928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18775BC9390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942744C0]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,23F1F843190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,33870AE9731F
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
       mov       rcx,7FF893D74928
       mov       edx,43
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23F1F849388
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
       mov       rcx,33870AE9731F
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
       mov       rdx,7FF893C64000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C64000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rdi,[rbp+68]
       test      rdi,rdi
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,7FF893D74928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23F1F849390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942744C0]
M01_L32:
       mov       rdi,[rbp+48]
       test      rdi,rdi
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,7FF893D74928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23F1F849390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942744C0]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,242A1873190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,1E2512D46717
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
       mov       rcx,7FF893D34928
       mov       edx,43
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,242A1879388
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
       mov       rcx,1E2512D46717
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
       mov       rdx,7FF893C24000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C24000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rdi,[rbp+68]
       test      rdi,rdi
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,7FF893D34928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,242A1879390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942344C0]
M01_L32:
       mov       rdi,[rbp+48]
       test      rdi,rdi
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,7FF893D34928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,242A1879390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942344C0]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,2031BC03190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,0EC7BF16EAE1D
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
       mov       rcx,7FF893D54928
       mov       edx,43
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2031BC09388
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
       mov       rcx,0EC7BF16EAE1D
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
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C44000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rdi,[rbp+68]
       test      rdi,rdi
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,7FF893D54928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2031BC09390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942544C0]
M01_L32:
       mov       rdi,[rbp+48]
       test      rdi,rdi
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,7FF893D54928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2031BC09390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942544C0]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,1731D833190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,3920D4CC8452
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
       mov       rcx,7FF893D54928
       mov       edx,43
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1731D839388
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
       mov       rcx,3920D4CC8452
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
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C44000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rdi,[rbp+68]
       test      rdi,rdi
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,7FF893D54928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1731D839390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942544C0]
M01_L32:
       mov       rdi,[rbp+48]
       test      rdi,rdi
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,7FF893D54928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1731D839390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942544C0]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,22AD5703190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,38CC731081B4
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
       mov       rcx,7FF893D54928
       mov       edx,43
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22AD5709388
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
       mov       rcx,38CC731081B4
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
       mov       rdx,7FF893C44000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C44000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rdi,[rbp+68]
       test      rdi,rdi
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,7FF893D54928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22AD5709390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942544C0]
M01_L32:
       mov       rdi,[rbp+48]
       test      rdi,rdi
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,7FF893D54928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22AD5709390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942544C0]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,1C34E4F3190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,9782D44C7A2E
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
       mov       rcx,7FF893D44928
       mov       edx,43
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C34E4F9388
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
       mov       rcx,9782D44C7A2E
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
       mov       rdx,7FF893C34000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C34000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rdi,[rbp+68]
       test      rdi,rdi
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,7FF893D44928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C34E4F9390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942444C0]
M01_L32:
       mov       rdi,[rbp+48]
       test      rdi,rdi
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,7FF893D44928
       mov       edx,44
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C34E4F9390
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8942444C0]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       cmp       [rcx],ecx
       mov       rdx,18FB93A3190
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
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 102
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,0D64E61D1A782
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
       mov       rcx,7FF893D74928
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18FB93A9390
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
       mov       rcx,0D64E61D1A782
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
       mov       rdx,7FF893C64000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF893C64000
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
       lea       r15d,[r15+r8+0FFFF]
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
       mov       rcx,18FB93A9388
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF894272B58]
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,18FB93A9388
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF894272B58]
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2C0]
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
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
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
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
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
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
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
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
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
; Total bytes of code 716
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C507C8
       call      qword ptr [7FF8942507C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C507D0
       call      qword ptr [7FF8942507D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507D8
       call      qword ptr [7FF8942507D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507D0
       call      qword ptr [7FF8942507D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507E0
       call      qword ptr [7FF8942507E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507E0
       call      qword ptr [7FF8942507E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C507C8
       call      qword ptr [7FF8942507C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C507D0
       call      qword ptr [7FF8942507D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507D8
       call      qword ptr [7FF8942507D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507D0
       call      qword ptr [7FF8942507D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507E0
       call      qword ptr [7FF8942507E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507E0
       call      qword ptr [7FF8942507E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C707C8
       call      qword ptr [7FF8942707C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C707D0
       call      qword ptr [7FF8942707D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C707D8
       call      qword ptr [7FF8942707D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C707D0
       call      qword ptr [7FF8942707D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C707E0
       call      qword ptr [7FF8942707E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C707E0
       call      qword ptr [7FF8942707E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C307C8
       call      qword ptr [7FF8942307C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C307D0
       call      qword ptr [7FF8942307D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C307D8
       call      qword ptr [7FF8942307D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C307D0
       call      qword ptr [7FF8942307D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C307E0
       call      qword ptr [7FF8942307E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C307E0
       call      qword ptr [7FF8942307E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C307C8
       call      qword ptr [7FF8942307C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C307D0
       call      qword ptr [7FF8942307D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C307D8
       call      qword ptr [7FF8942307D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C307D0
       call      qword ptr [7FF8942307D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C307E0
       call      qword ptr [7FF8942307E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C307E0
       call      qword ptr [7FF8942307E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C507C8
       call      qword ptr [7FF8942507C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C507D0
       call      qword ptr [7FF8942507D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507D8
       call      qword ptr [7FF8942507D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507D0
       call      qword ptr [7FF8942507D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507E0
       call      qword ptr [7FF8942507E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507E0
       call      qword ptr [7FF8942507E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C407C8
       call      qword ptr [7FF8942407C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C407D0
       call      qword ptr [7FF8942407D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C407D8
       call      qword ptr [7FF8942407D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C407D0
       call      qword ptr [7FF8942407D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C407E0
       call      qword ptr [7FF8942407E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C407E0
       call      qword ptr [7FF8942407E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C507C8
       call      qword ptr [7FF8942507C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C507D0
       call      qword ptr [7FF8942507D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507D8
       call      qword ptr [7FF8942507D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507D0
       call      qword ptr [7FF8942507D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507E0
       call      qword ptr [7FF8942507E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C507E0
       call      qword ptr [7FF8942507E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitRemoveEmpty()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+2C0]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       mov       rcx,rax
       mov       r11,7FF893C707C8
       call      qword ptr [7FF8942707C8]
       mov       rcx,rax
       mov       [rbp+0FFF0],rcx
       mov       r11,7FF893C707D0
       call      qword ptr [7FF8942707D0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C707D8
       call      qword ptr [7FF8942707D8]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C707D0
       call      qword ptr [7FF8942707D0]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C707E0
       call      qword ptr [7FF8942707E0]
       nop
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FF893C707E0
       call      qword ptr [7FF8942707E0]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 220
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,21E90B31B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21E90B31AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89426E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,14435731B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,14435731AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89425E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89405F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,174623E1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,174623E1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89422E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89408F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,242172E1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,242172E1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89425E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1924EFC1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1924EFC1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89426E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,23B46761B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,23B46761AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89423E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89406F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,2AFE7E91B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2AFE7E91AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89423E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89407F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,20419691B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,20419691AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89424E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       ecx,65D
       mov       rdx,7FF89409F278
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
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,256163E1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,256163E1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF89426E9A8]
       mov       rcx,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D54928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D54928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D74928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D64928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D34928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D34928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D44928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
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
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 84
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
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF893D34928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

